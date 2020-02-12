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
        DataView dv;
        string idecka = "";

        public frmChladnicka()
        {
            InitializeComponent();
            NaplnDB();
        }

        private void NaplnDB()
        {
            retSql = "Select * from Suroviny Order by Surovina";
            DA = new SqlDataAdapter(retSql, conn);
            DA.Fill(DS, "Suroviny");

            dv = new DataView(DS.Tables["Suroviny"]);
            NastavCombo();
        }

        private void NastavCombo()
        {
            
            dv.RowFilter = "IdS not in (0"+ idecka+")";
            cboSuroviny.DataSource = dv;
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
            idecka += ","+lvi.Text;
            NastavCombo();
            btnPridaj.Enabled = dv.Count > 0;
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
    }
}
