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
            dgvJedla.Columns[0].Visible = false;
            dgvJedla.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

            dgvJedla.DataSource = DS.Tables["Jedla"];
            dgvJedla.Columns[0].Visible = false;
            //dataGridView1.Columns[2].Visible = false;


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

            //if (dataGridView1.SelectedRows.Count > 0)
            //    cboKategorie.ComboBox.SelectedValue = dataGridView1.SelectedRows[0].Cells["IdK"].Value;

            cboKategoria.ComboBox.DataSource = DS.Tables["Kategorie"];
            cboKategoria.ComboBox.DisplayMember = "Kategoria";
            cboKategoria.ComboBox.ValueMember = "IdK";


        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            if (dgvJedla.SelectedRows.Count != 0)
            {
                int idj = (int)dgvJedla.SelectedRows[0].Cells["IdJ"].Value;
                //retSql = "Update Jedla Set Jedlo = '" + txtText.Text + "' , IdKFK='" + cboKategorie.ComboBox.SelectedValue + "'  Where IdJ=" + idj;
                //cmd = new SqlCommand(retSql, conn);
                //try
                //{
                //    cmd.Connection.Open();
                //    cmd.ExecuteNonQuery();
                //    cmd.Connection.Close();
                //    NaplnDb();
                //}
                //catch (Exception ex)
                //{
                //    if (cmd.Connection.State != ConnectionState.Closed) cmd.Connection.Close();
                //    MessageBox.Show(ex.Message);
                //}
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
            if (dgvJedla.Focused)
            {
                //if (dataGridView1.SelectedRows.Count > 0)
                //{
                //    // txtText.Text = (string)dataGridView1.SelectedRows[0].Cells["Jedlo"].Value;
                //    // txtKategoria.Text = (string)dataGridView1.SelectedRows[0].Cells["Kategoria"].Value;
                //    //cboKategorie.ComboBox.SelectedValue = dataGridView1.SelectedRows[0].Cells["IdK"].Value;
                //}
            }
            else
                dgvJedla.ClearSelection();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtJedla_TextChanged(object sender, EventArgs e)
        {
            NastavFilter();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            VymazRiadok(dgvJedla.SelectedRows[0]);
        }

        private void VymazRiadok(DataGridViewRow riadok)
        {
            if (MessageBox.Show("Naozaj chcete vymazat?", "Pozor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (dgvJedla.SelectedRows.Count != 0)
                {
                    int idj = (int)riadok.Cells["IdJ"].Value;
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
            tlsEdit.Visible = false;
            NaplnDb();
            dgvJedla.Columns[0].Visible = false;
            dgvJedla.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvJedla.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void BtnReceptura_Click(object sender, EventArgs e)
        {
            OtvorRecepturu();
        }

        private void OtvorRecepturu()
        {
            int idj = (int)dgvJedla.SelectedRows[0].Cells["IdJ"].Value;
            string nazov = (string)dgvJedla.SelectedRows[0].Cells["Jedlo"].Value;

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
            int idk = (int)cboKategorie.ComboBox.SelectedValue;
            frmKategorie frmKat = new frmKategorie();
            frmKat.StartPosition = FormStartPosition.CenterScreen;
            frmKat.ShowDialog();
            frmKat.Dispose();
            NaplnDbKategorie();
        }

        private void CboKategorie_TextChanged(object sender, EventArgs e)
        {

        }

        private void NastavFilter()
        {
            string JedloFilter = txtJedla.Text;
            string KategoriaFilter = cboKategorie.Text == "Všetky" ? "" : cboKategorie.Text;
            //string KategoriaFilter = cboKategorie.SelectedIndex==0 ? "" : cboKategorie.Text;


            DataView dvv = DS.Tables["Jedla"].DefaultView;
            dvv.RowFilter = "Jedlo like '%" + JedloFilter + "%' and Kategoria like '%"
                + KategoriaFilter + "%'";
            //dvv.RowFilter = "Jedlo like '%" + txtJedla.Text + "%'";
            //dvv.RowFilter = "Kategoria like '%" + cboKategorie.Text + "%'";
            btnVymaz.Enabled = dvv.Count > 0;
            // if (dvv.Count == 0) txtText.Text = txtJedla.Text;

            btnReceptura.Enabled = dvv.Count > 0;
        }

        private void CboKategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKategorie.ComboBox.Focused) NastavFilter();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["IdK"].Value = cboKategorie.ComboBox.SelectedValue;
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            //dataGridView1.CellEndEdit();
            if (DS.HasChanges())
            {
                DA.Update(DS.Tables["Jedla"]);
            }
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip cm = new ContextMenuStrip();
                int currentRow = dgvJedla.HitTest(e.X, e.Y).RowIndex;

                if (!(currentRow >= 0))
                {
                    cm.Items.Add("Add");
                }
                else
                {
                    dgvJedla.CurrentCell = dgvJedla.Rows[currentRow].Cells["Jedlo"];
                    dgvJedla.Rows[currentRow].Selected = true;
                    cm.Items.Add("Edit");
                    cm.Items.Add("Delete");
                }
                cm.ItemClicked += new ToolStripItemClickedEventHandler(cm_ItemClicked);

                cm.Show(dgvJedla, new Point(e.X, e.Y));
            }

        }
        private void cm_ItemClicked(Object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem mojaPolozka = e.ClickedItem;
            DataGridViewRow riadok;
            switch (mojaPolozka.Text.ToUpper())
            {
                case "ADD":
                    retSql = "Insert Into Jedla (Jedlo,IdKFK)Values('nova polozka',8)";
                    using (var connection = new SqlConnection(conn.ConnectionString))
                    {
                        cmd.CommandText = retSql;
                        cmd.Connection = connection;
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        NaplnDb();
                    };
                    int PocetJedal = DS.Tables["Jedla"].Rows.Count;
                    dgvJedla.FirstDisplayedScrollingRowIndex = PocetJedal - 1;
                    dgvJedla.CurrentCell = dgvJedla.Rows[PocetJedal - 1].Cells["Jedlo"];
                    dgvJedla.Rows[PocetJedal - 1].Selected = true;

                    riadok = dgvJedla.CurrentRow;
                    EditujPolozku(riadok);
                    break;
                case "EDIT":
                    riadok = dgvJedla.CurrentRow;
                    EditujPolozku(riadok);

                    break;
                case "DELETE":
                    int currentRow = dgvJedla.CurrentRow.Index;
                    // VymazRiadok();
                    break;
            }

        }

        private void EditujPolozku(DataGridViewRow riadok)
        {
            tlsEdit.Visible = true;

            lblIdJ.Text = riadok.Cells["IdJ"].Value.ToString();
            txtJedlo.Text = riadok.Cells["Jedlo"].Value.ToString();
            lblIdKFk.Text = riadok.Cells["IdK"].Value.ToString();
            cboKategoria.ComboBox.SelectedValue = lblIdKFk.Text;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            tlsEdit.Visible = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string noveJedlo = txtJedlo.Text;
            if (string.IsNullOrEmpty(noveJedlo)) return;

            string retsql = "Select Count(IdJ)as Pocet From Jedla Where Upper(Jedlo) = '" + noveJedlo.ToUpper()
                + "' and IdKFK = " + lblIdKFk.Text;
            using (var connection = new SqlConnection(conn.ConnectionString))
            {
                cmd.CommandText = retsql;
                cmd.Connection = connection;
                cmd.Connection.Open();
                int pocet = (int)cmd.ExecuteScalar();
                if (pocet == 0)
                {
                    //nove jedlo
                    int riadokDgv = dgvJedla.FirstDisplayedScrollingRowIndex;
                    int aktivnyRiadok = dgvJedla.CurrentRow.Index;

                    retsql = "Update Jedla Set Jedlo ='" + noveJedlo + "', IdKFK =" + lblIdKFk.Text
                        + "  Where IdJ = " + lblIdJ.Text;
                    cmd.CommandText = retsql;
                    cmd.ExecuteNonQuery();
                    NaplnDb();
                    tlsEdit.Visible = false;

                    if (DS.Tables["Jedla"].DefaultView.Count > 0)
                    {
                        dgvJedla.FirstDisplayedScrollingRowIndex = riadokDgv;
                        if (DS.Tables["Jedla"].DefaultView.Count > aktivnyRiadok)
                            dgvJedla.CurrentCell = dgvJedla.Rows[aktivnyRiadok].Cells["Jedlo"];
                    }

                }
                else
                {
                    //existujuce jedlo
                    MessageBox.Show("Jedlo už existuje!!!!");
                    txtJedlo.Focus();
                    txtJedlo.SelectAll();
                }
            };


        }

        private void CboKategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKategoria.ComboBox.SelectedValue != null)
                lblIdKFk.Text = cboKategoria.ComboBox.SelectedValue.ToString();
        }

        private void CboKategorie_Click(object sender, EventArgs e)
        {

        }
    }
}
