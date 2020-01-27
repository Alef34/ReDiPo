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
        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection("Data Source=USER-02-C2\\SQLEXPRESS;Integrated Security=False;Initial Catalog=Redipo; User ID=sa;Password=;Pooling=False");
        SqlCommand cmd;
        string retSql = "";


        public frmReceptura(int idjedlo)
        {
            InitializeComponent();
            idJedlo = idjedlo;

        }

        private void BtnZatvor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmReceptura_Load(object sender, EventArgs e)
        {
            lblId.Text = idJedlo.ToString();
            NaplnDb();
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
        }
    }
}
