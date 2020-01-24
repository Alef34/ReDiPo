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
    public partial class frmSuroviny : Form
    {

        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection("Data Source=USER-02-C2\\SQLEXPRESS;Integrated Security=False;Initial Catalog=Redipo; User ID=sa;Password=;Pooling=False");
        SqlCommand cmd;
        string retSql = "";


        public frmSuroviny()
        {
            InitializeComponent();
        }

        private void FrmSuroviny_Load(object sender, EventArgs e)
        {
            NaplnDb();
        }


        private void NaplnDb()
        {
            retSql = "Select * from Suroviny";
            cmd = new SqlCommand(retSql, conn);
            cmd.CommandType = CommandType.Text;
            DA.SelectCommand = cmd;
            if (DS.Tables["Suroviny"] != null) DS.Tables["Suroviny"].Clear();
            DA.Fill(DS, "Suroviny");

            dataGridView1.DataSource = DS;
            dataGridView1.DataMember = "Suroviny";
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            retSql = "Insert Into Suroviny (Surovina) Values ('Nova surovina')";
            cmd = new SqlCommand(retSql, conn);
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                NaplnDb();
            }
            catch (Exception ex)
            {
                if (cmd.Connection.State != ConnectionState.Closed) cmd.Connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            int ids = (int)dataGridView1.SelectedRows[0].Cells["IdS"].Value;
            retSql = "Update Suroviny Set Surovina = '"+ txtSurovina.Text  +"' Where IdS="+ ids;
            cmd = new SqlCommand(retSql, conn);
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                NaplnDb();
            }
            catch (Exception ex)
            {
                if (cmd.Connection.State != ConnectionState.Closed) cmd.Connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                txtSurovina.Text = (string)dataGridView1.SelectedRows[0].Cells["Surovina"].Value;
        }
    }
}
