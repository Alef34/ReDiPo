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
    public partial class Form1 : Form
    {

        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection("Data Source=USER-02-C2\\SQLEXPRESS;Integrated Security=False;Initial Catalog=Redipo; User ID=sa;Password=;Pooling=False");
        SqlCommand cmd;
        string retSql = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            NaplnDb();
        }

        private void NaplnDb()
        {
            retSql = @"SELECT        dbo.JEDLA.IdJ, dbo.JEDLA.Jedlo, dbo.SUROVINY.IdS, dbo.SUROVINY.Surovina, dbo.RECEPTURY.D0, dbo.RECEPTURY.D1, dbo.RECEPTURY.D2, dbo.RECEPTURY.D3, dbo.RECEPTURY.D4, dbo.RECEPTURY.D5, 
                         dbo.RECEPTURY.D6, dbo.RECEPTURY.D8, dbo.RECEPTURY.D9, dbo.RECEPTURY.D10, dbo.RECEPTURY.D11
                    FROM            dbo.SUROVINY INNER JOIN
                         dbo.RECEPTURY ON dbo.SUROVINY.IdS = dbo.RECEPTURY.IdSFK RIGHT OUTER JOIN
                         dbo.JEDLA ON dbo.RECEPTURY.IdJFK = dbo.JEDLA.IdJ";

            retSql = "Select * from Jedla";
            cmd = new SqlCommand(retSql, conn);
            cmd.CommandType = CommandType.Text;
            DA.SelectCommand = cmd;
            if (DS.Tables["Jedla"] != null) DS.Tables["Jedla"].Clear();
            DA.Fill(DS, "Jedla");

            dataGridView1.DataSource = DS.Tables["Jedla"];
        }

        private void TxtFilterS_TextChanged(object sender, EventArgs e)
        {
            DataView dv = DS.Tables["Jedla"].DefaultView;
            dv.RowFilter = "Surovina like '%" + txtFilterS.Text + "%' ";
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            retSql = "Insert Into Jedla (Jedlo) Values ('Nove jedlo')";
            cmd = new SqlCommand(retSql, conn);
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                NaplnDb();
            }
            catch (Exception ex )
            {
                if (cmd.Connection.State != ConnectionState.Closed) cmd.Connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            frmSuroviny frmSur = new frmSuroviny();
            frmSur.StartPosition = FormStartPosition.CenterScreen;
            frmSur.ShowDialog();
            frmSur.Dispose();
        }

        private void TxtFilterS_Click(object sender, EventArgs e)
        {

        }

        private void BtnJedla_Click(object sender, EventArgs e)
        {
            frmJedla frmJed = new frmJedla();
            frmJed.StartPosition = FormStartPosition.CenterScreen;
            frmJed.ShowDialog();
            frmJed.Dispose();

        }
    }
}
