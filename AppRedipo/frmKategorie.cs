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
    public partial class frmKategorie : Form
    {

        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection("Data Source=USER-02-C2\\SQLEXPRESS;Integrated Security=False;Initial Catalog=Redipo; User ID=sa;Password=;Pooling=False");
        SqlCommand cmd;
        string retSql = "";


        public frmKategorie()
        {
            InitializeComponent();
        }

        private void FrmKategorie_Load(object sender, EventArgs e)
        {
            NaplnDb();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void NaplnDb()
        {
            retSql = "Select * from Kategorie";
            cmd = new SqlCommand(retSql, conn);
            cmd.CommandType = CommandType.Text;
            DA.SelectCommand = cmd;
            if (DS.Tables["Kategorie"] != null) DS.Tables["Kategorie"].Clear();
            DA.Fill(DS, "Kategorie");

            dataGridView1.DataSource = DS.Tables["Kategorie"];
        }

       

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int idk = (int)dataGridView1.SelectedRows[0].Cells["IdK"].Value;
                retSql = "Update Kategorie Set Kategoria = '" + txtKategoriaText.Text + "' Where IdK=" + idk;
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
            else
            {
                retSql = "Insert Into Kategorie (Kategoria)Values('" + txtKategoriaText.Text + "')";
                try
                {
                    string pomS = txtKategoriaText.Text;
                    cmd.CommandText = retSql;
                    cmd.Connection = conn;
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    NaplnDb();
                    txtKategoriaFilter.Text = pomS;
                }
                catch (Exception ex)
                {
                    if (cmd.Connection.State != ConnectionState.Closed) cmd.Connection.Close();
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                txtKategoriaText.Text = (string)dataGridView1.SelectedRows[0].Cells["Kategoria"].Value;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSurovina_TextChanged(object sender, EventArgs e)
        {
            DataView dvv = DS.Tables["Kategorie"].DefaultView;
            dvv.RowFilter = "Kategoria like '%" + txtKategoriaFilter.Text + "%'";
            btnVymaz.Enabled = dvv.Count > 0;
            if (dvv.Count == 0) txtKategoriaText.Text = txtKategoriaFilter.Text;
            btnPrepis.Text = dvv.Count > 0 ? "Prepis" : "Pridaj";


        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Naozaj chcete vymazat?", "Pozor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    int idk = (int)dataGridView1.SelectedRows[0].Cells["IdK"].Value;
                    retSql = "Delete From Kategorie Where IdK=" + idk;
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

        }

        private void TxtSurovina_Click(object sender, EventArgs e)
        {

        }
    }
}
