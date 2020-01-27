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
    public partial class frmIngrediencia : Form
    {
        private int idJedlo;

        private bool prepisujem = false;

        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection("Data Source=USER-02-C2\\SQLEXPRESS;Integrated Security=False;Initial Catalog=Redipo; User ID=sa;Password=;Pooling=False");
        SqlCommand cmd;
        string retSql = "";

        public frmIngrediencia(int idjedlo)
        {
            InitializeComponent();
            idJedlo = idjedlo;
        }

        private void FrmIngrediencia_Load(object sender, EventArgs e)
        {
            NaplnDb();
        }

        private void NaplnDb()
        {
            retSql = "Select * From Suroviny Order By Surovina";

            cmd = new SqlCommand(retSql, conn);
            cmd.CommandType = CommandType.Text;
            DA.SelectCommand = cmd;
            if (DS.Tables["Suroviny"] != null) DS.Tables["Suroviny"].Clear();
            DA.Fill(DS, "Suroviny");

            cboSuroviny.DataSource = DS.Tables["Suroviny"];
            cboSuroviny.DisplayMember = "Surovina";
            cboSuroviny.ValueMember = "IdS";

        }

        private void CboSuroviny_SelectedValueChanged(object sender, EventArgs e)
        {
            NacitajIngredienciu();
        }

        private void NacitajIngredienciu()
        {
            if (cboSuroviny.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                retSql = "Select * From Receptury Where IdJFK=" + idJedlo + " and IdSFK=" + cboSuroviny.SelectedValue;

                cmd = new SqlCommand(retSql, conn);
                cmd.CommandType = CommandType.Text;
                DA.SelectCommand = cmd;
                if (DS.Tables["Ingrediencia"] != null) DS.Tables["Ingrediencia"].Clear();
                DA.Fill(DS, "Ingrediencia");

                if (DS.Tables["Ingrediencia"].Rows.Count == 0)
                {
                    prepisujem = false;
                    txtD0.Text = "0";
                    txtD1.Text = "0";
                }
                else if (DS.Tables["Ingrediencia"].Rows.Count == 1)
                {
                    prepisujem = true;
                    DataRow dr = DS.Tables["Ingrediencia"].Rows[0];
                    txtD0.Text = dr["D0"].ToString();
                    txtD1.Text = dr["D1"].ToString();
                }
                else
                {
                    throw new SyntaxErrorException();
                }
            }
        }


        //private void CboSuroviny_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Index:" + cboSuroviny.SelectedIndex.ToString());
        //}
    }
}
