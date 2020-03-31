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
    public partial class frmJedla : Form
    {

        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection("Data Source=USER-02-C2\\SQLEXPRESS;Integrated Security=False;Initial Catalog=Redipo; User ID=sa;Password=;Pooling=False");
        SqlCommand cmd;
        string retSql = "";


        public frmJedla()
        {
            InitializeComponent();
        }

        private void FrmSuroviny_Load(object sender, EventArgs e)
        {
            NaplnDb();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void NaplnDb()
        {
            retSql = @"Select j.IdJ, j.Jedlo, k.IdK, k.Kategoria from  Jedla j
                        Join Kategorie k
                        on k.IdK = j.IdKFK";
            cmd = new SqlCommand(retSql, conn);
            cmd.CommandType = CommandType.Text;
            DA.SelectCommand = cmd;
            if (DS.Tables["Jedla"] != null) DS.Tables["Jedla"].Clear();
            DA.Fill(DS, "Jedla");

            dataGridView1.DataSource = DS.Tables["Jedla"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;


            NaplnDbKategorie();
            
        }

        private void NaplnDbKategorie()
        {
            retSql = "Select * from Kategorie";
            cmd.CommandText = retSql;
            DA.SelectCommand = cmd;
            if (DS.Tables["Kategorie"] != null) DS.Tables["Kategorie"].Clear();
            DA.Fill(DS, "Kategorie");


            cboKategorie.ComboBox.DataSource = DS.Tables["Kategorie"];
            cboKategorie.ComboBox.DisplayMember = "Kategoria";
            cboKategorie.ComboBox.ValueMember = "IdK";



            if (dataGridView1.SelectedRows.Count > 0)
                cboKategorie.ComboBox.SelectedValue = dataGridView1.SelectedRows[0].Cells["IdK"].Value;

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int idj = (int)dataGridView1.SelectedRows[0].Cells["IdJ"].Value;
                retSql = "Update Jedla Set Jedlo = '" + txtText.Text + "' , IdKFK='" + cboKategorie.ComboBox.SelectedValue + "'  Where IdJ=" + idj;
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
                retSql = "Insert Into Jedla (Jedlo,IdKFK)Values('" + txtJedla.Text + "','" + cboKategorie.ComboBox.SelectedValue + "')";
                using (var connection = new SqlConnection(conn.ConnectionString))
                {
                    cmd.CommandText = retSql;
                    cmd.Connection = connection;
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    NaplnDb();
                };
            }

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtText.Text = (string)dataGridView1.SelectedRows[0].Cells["Jedlo"].Value;
                // txtKategoria.Text = (string)dataGridView1.SelectedRows[0].Cells["Kategoria"].Value;
                cboKategorie.ComboBox.SelectedValue = dataGridView1.SelectedRows[0].Cells["IdK"].Value;
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtJedla_TextChanged(object sender, EventArgs e)
        {
            DataView dvv = DS.Tables["Jedla"].DefaultView;
            dvv.RowFilter = "Jedlo like '%" + txtJedla.Text + "%' or Kategoria like '%" + txtJedla.Text + "%'";
            btnVymaz.Enabled = dvv.Count > 0;
            btnPrepis.Text = dvv.Count > 0 ? "Prepis" : "Pridaj";
            btnReceptura.Enabled = dvv.Count > 0;
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Naozaj chcete vymazat?", "Pozor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    int idj = (int)dataGridView1.SelectedRows[0].Cells["IdJ"].Value;
                    retSql = "Delete From Jedla Where IdJ=" + idj;
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

        private void FrmJedla_Load(object sender, EventArgs e)
        {
            NaplnDb();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BtnReceptura_Click(object sender, EventArgs e)
        {
            OtvorRecepturu();
        }

        private void OtvorRecepturu()
        {
            int idj = (int)dataGridView1.SelectedRows[0].Cells["IdJ"].Value;
            string nazov = (string)dataGridView1.SelectedRows[0].Cells["Jedlo"].Value;

            frmReceptura frmRep = new frmReceptura(idj, nazov);

            frmRep.StartPosition = FormStartPosition.CenterScreen;
            frmRep.ShowDialog();
            frmRep.Dispose();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            OtvorRecepturu();
        }

        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            int idk =(int)cboKategorie.ComboBox.SelectedValue;
            frmKategorie frmKat = new frmKategorie();
            frmKat.StartPosition = FormStartPosition.CenterScreen;
            frmKat.ShowDialog();
            frmKat.Dispose();
            NaplnDbKategorie();
        }

       
    }
}
