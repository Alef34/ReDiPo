using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRedipo
{
    public partial class frmReceptura : Form
    {
        private int idJedlo;
        private string nazovJedla;
        private bool dovolEditovat;

        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection("Data Source=USER-02-C2\\SQLEXPRESS;Integrated Security=False;Initial Catalog=Redipo; User ID=sa;Password=;Pooling=False");
        SqlCommand cmd;

        string retSql = "";


        public frmReceptura(int _idjedlo, string _nazovjedla, bool _DovolEditovat=true)
        {
            InitializeComponent();
            idJedlo = _idjedlo;
            dovolEditovat = _DovolEditovat;
            nazovJedla = _nazovjedla;

        }

        private void BtnZatvor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmReceptura_Load(object sender, EventArgs e)
        {
            lblId.Text = idJedlo.ToString()+" - "+ nazovJedla;
            this.Font = new Font("Courier New", 8);
            lblId.Font = new Font(this.Font.FontFamily, 20.0f,FontStyle.Bold | FontStyle.Italic);
            this.Text= nazovJedla;
            NaplnDb();
            btnPridaj.Visible = dovolEditovat;

            this.Location = new Point(10, 10);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            this.ControlBox = true;
            
        }

        private void NaplnDb()
        {
            retSql = @"SELECT dbo.RECEPTURY.IdR, dbo.RECEPTURY.IdJFK, dbo.SUROVINY.IdS, dbo.SUROVINY.Surovina, dbo.RECEPTURY.D0, dbo.RECEPTURY.D1, dbo.RECEPTURY.D2, dbo.RECEPTURY.D3, dbo.RECEPTURY.D4, dbo.RECEPTURY.D5, 
                                dbo.RECEPTURY.D6, dbo.RECEPTURY.D8, dbo.RECEPTURY.D9, dbo.RECEPTURY.D10, dbo.RECEPTURY.D11
                            FROM dbo.RECEPTURY INNER JOIN
                                    dbo.SUROVINY ON dbo.RECEPTURY.IdSFK = dbo.SUROVINY.IdS 
                            Where IdJFK=" + idJedlo.ToString();

            cmd = new SqlCommand(retSql, conn);
            cmd.CommandType = CommandType.Text;
            DA.SelectCommand = cmd;
            if (DS.Tables["Ingrediencie"] != null) DS.Tables["Ingrediencie"].Clear();
            DA.Fill(DS, "Ingrediencie");

            dgvIngrediencie.DataSource = DS.Tables["Ingrediencie"];
            dgvIngrediencie.Columns["IdR"].Visible = false;
            dgvIngrediencie.Columns["IdJFK"].Visible = false;
            dgvIngrediencie.Columns["IdS"].Visible = false;

            

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            frmIngrediencia frmI = new frmIngrediencia(idJedlo);
            frmI.StartPosition = FormStartPosition.CenterScreen;
            frmI.ShowDialog();
            frmI.Dispose();
            NaplnDb();
        }

        private void DgvIngrediencie_DoubleClick(object sender, EventArgs e)
        {
            if (dovolEditovat && dgvIngrediencie.SelectedRows.Count > 0  )
            {
                DataGridViewRow riadok = dgvIngrediencie.SelectedRows[0];

                frmIngrediencia frmI = new frmIngrediencia(idJedlo, (int)riadok.Cells["IdS"].Value);
                frmI.StartPosition = FormStartPosition.CenterScreen;
                frmI.ShowDialog();
                frmI.Dispose();
                NaplnDb();
            }
            
        }

        private void DgvIngrediencie_SelectionChanged(object sender, EventArgs e)
        {
            btnVymaz.Enabled = (dgvIngrediencie.SelectedRows.Count > 0);
        }

        private void BtnVymaz_Click(object sender, EventArgs e)
        {
            int idR =(int)dgvIngrediencie.SelectedRows[0].Cells["IdR"].Value;
            retSql = "Delete From Receptury Where IdR= @IdR ";
            cmd.CommandText = retSql;
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@IdR";
            param.SqlDbType = SqlDbType.Int;
            param.Value = idR;

            cmd.Parameters.Add(param);
            cmd.Connection = conn;

            try
            {
                cmd.Connection.Open();
                int pocet = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                if (cmd.Connection.State != ConnectionState.Closed) cmd.Connection.Close();
                MessageBox.Show(ex.Message);
            }
            NaplnDb();
        }


       



        private void FrmReceptura_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Button btn = (Button)sender;

             

                    if (MessageBox.Show("Chcete uložiť zmeny?", "Pozor",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2 ) == DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
