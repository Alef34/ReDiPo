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
    public partial class frmChladnicka : Form
    {

        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection("Data Source=USER-02-C2\\SQLEXPRESS;Integrated Security=False;Initial Catalog=Redipo; User ID=sa;Password=;Pooling=False");
        SqlCommand cmd;
        string retSql = "";
        DataView dvSuroviny;
        DataView dvJedla;
        DataView dvJedlaVsetky;


        DataView dvReceptury;
        string idecka = "";
        List<string> _idecka = new List<string>();

        public frmChladnicka()
        {
            InitializeComponent();
            NaplnDB();
        }

        private void NaplnDB()
        {
            retSql = "Select * from Suroviny Order by Surovina";
            DA = new SqlDataAdapter(retSql, conn);
            if (DS.Tables["Suroviny"] != null) DS.Tables["Suroviny"].Clear();
            DA.Fill(DS, "Suroviny");
            dvSuroviny = new DataView(DS.Tables["Suroviny"]);
            NastavCombo();


            retSql = "Select * from Receptury ";
            DA = new SqlDataAdapter(retSql, conn);
            if (DS.Tables["Receptury"] != null) DS.Tables["Receptury"].Clear();
            DA.Fill(DS, "Receptury");
            dvReceptury = new DataView(DS.Tables["Receptury"]);


            retSql = "Select Distinct * from Jedla";

            DA = new SqlDataAdapter(retSql, conn);
            if (DS.Tables["Jedla"] != null) DS.Tables["Jedla"].Clear();
            DA.Fill(DS, "Jedla");

            DataColumn col = new DataColumn();
            col.ColumnName = "Pocet";
            col.DataType = System.Type.GetType("System.Int32");

            DS.Tables["Jedla"].Columns.Add(col);

            foreach (DataRow riadok in DS.Tables["Jedla"].Rows)
                riadok["Pocet"] = 0;



            dvJedla = new DataView(DS.Tables["Jedla"]);
            dvJedla.RowFilter = "Pocet = 0";
            dgvJedla.DataSource = dvJedla;//.ToTable(true, new string[] { "IdJ", "Jedlo" });

            dgvJedla.Columns["IdJ"].Visible = false;
            dgvJedla.Columns["IdKFK"].Visible = false;
            dgvJedla.Columns["Pocet"].Visible = false;

            dgvJedla.Columns["Jedlo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvJedla.ReadOnly = true;


            dvJedlaVsetky = new DataView(DS.Tables["Jedla"]);

            dgvJedlaVsetky.DataSource = dvJedlaVsetky;
        }

        private void NastavCombo()
        {

            dvSuroviny.RowFilter = "IdS not in (0" + idecka + ")";
            cboSuroviny.DataSource = dvSuroviny;
            cboSuroviny.DisplayMember = "Surovina";
            cboSuroviny.ValueMember = "IdS";


        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPridaj_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = cboSuroviny.SelectedValue.ToString();
            lvi.SubItems.Add(cboSuroviny.Text);
            lvi.SubItems.Add(txtMnozstvo.Text);
            lstSuroviny.Items.Add(lvi);
            idecka += "," + lvi.Text;

            NastavCombo();
            btnPridaj.Enabled = dvSuroviny.Count > 0;

            foreach (DataRow riadok in DS.Tables["Jedla"].Rows)
            {
                dvReceptury.RowFilter = "IdJFK=" + riadok["IdJ"] + " and IdSFK=" + lvi.Text;
                if (dvReceptury.Count == 0)
                    riadok["Pocet"] = (int)riadok["Pocet"] + 1;
            }
            //dgvJedla.DataSource = dvJedla;
        }

        private void FrmChladnicka_Load(object sender, EventArgs e)
        {
            lstSuroviny.Columns[0].Width = 20;
            lstSuroviny.Columns[1].Width = 200;
            lstSuroviny.Columns[2].Width = 200;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string id = lstSuroviny.SelectedItems[0].SubItems[0].Text;
            MessageBox.Show(id);
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {

            string IdS = lstSuroviny.SelectedItems[0].Text;

            idecka += ",K";
            idecka = idecka.Replace("," + IdS + ",", ",");
            idecka = idecka.Replace(",K", "");

            NastavCombo();
            lstSuroviny.SelectedItems[0].Remove();

            foreach (DataRow riadok in DS.Tables["Jedla"].Rows)
            {
                dvReceptury.RowFilter = "IdJFK=" + riadok["IdJ"] + " and IdSFK=" + IdS;
                if (dvReceptury.Count == 0)
                    riadok["Pocet"] = (int)riadok["Pocet"] - 1;
            }

            // dgvJedla.DataSource = dvJedla;
            btnVymaz.Enabled = false;
        }

        private void LstSuroviny_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVymaz.Enabled = (lstSuroviny.SelectedItems.Count > 0);
        }

        private void DgvJedla_DoubleClick(object sender, EventArgs e)
        {
            if (dgvJedla.CurrentRow == null) return;
          
            int id1 = (int)dgvJedla.CurrentRow.Cells["IdJ"].Value;
            string nazov= (string)dgvJedla.CurrentRow.Cells["Jedlo"].Value;

            frmReceptura frm = new frmReceptura(id1,nazov, false);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            frm.Dispose();


        }

        private void DgvJedla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
