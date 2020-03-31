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
        private int idSuroviny;
        private int idR = -1;
        private int idS = -1;


        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection("Data Source=USER-02-C2\\SQLEXPRESS;Integrated Security=False;Initial Catalog=Redipo; User ID=sa;Password=;Pooling=False");
        SqlCommand cmd;
        string retSql = "";

        public frmIngrediencia(int _idJedlo, int _idSuroviny=-1)
        {
            InitializeComponent();
            idJedlo = _idJedlo;
            idSuroviny = _idSuroviny;
        }

        private void FrmIngrediencia_Load(object sender, EventArgs e)
        {
            NaplnDb();
        }

        private void NaplnDb()
        {
            if (idSuroviny == -1)
                retSql = "Select * From Suroviny Order By Surovina";
            else
                retSql = "Select * From Suroviny Where IdS="+ idSuroviny;
            

                       
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
                idS = (int)cboSuroviny.SelectedValue;
                retSql = "Select * From Receptury Where IdJFK=" + idJedlo + " and IdSFK=" + idS;

                cmd = new SqlCommand(retSql, conn);
                cmd.CommandType = CommandType.Text;
                DA.SelectCommand = cmd;
                if (DS.Tables["Ingrediencia"] != null) DS.Tables["Ingrediencia"].Clear();
                DA.Fill(DS, "Ingrediencia");

                if (DS.Tables["Ingrediencia"].Rows.Count == 0)
                {
                    idR = -1;
                    txtD0.Text = "0";
                    txtD1.Text = "0";
                    txtD2.Text = "0";
                    txtD3.Text = "0";
                    txtD4.Text = "0";
                    txtD5.Text = "0";
                    txtD6.Text = "0";
                    txtD8.Text = "0";
                    txtD9.Text = "0";
                    txtD10.Text = "0";
                    txtD11.Text = "0";
                }
                else if (DS.Tables["Ingrediencia"].Rows.Count == 1)
                {
                    idR = (int)DS.Tables["Ingrediencia"].Rows[0]["IdR"];
                    DataRow dr = DS.Tables["Ingrediencia"].Rows[0];
                    txtD0.Text = dr["D0"].ToString();
                    txtD1.Text = dr["D1"].ToString();
                    txtD2.Text = dr["D2"].ToString();
                    txtD3.Text = dr["D3"].ToString();
                    txtD4.Text = dr["D4"].ToString();
                    txtD5.Text = dr["D5"].ToString();
                    txtD6.Text = dr["D6"].ToString();
                    txtD8.Text = dr["D8"].ToString();
                    txtD9.Text = dr["D9"].ToString();
                    txtD10.Text = dr["D10"].ToString();
                    txtD11.Text = dr["D11"].ToString();

                }
                else
                {
                    throw new SyntaxErrorException();
                }
            }
        }

        private void CboSuroviny_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCloseAndSave_Click(object sender, EventArgs e)
        {
            if (idR > 0)
            {
                //prepis
                retSql = "Update Receptury Set D0=" + txtD0.Text +
                            ", D1=" + txtD1.Text + ", D2=" + txtD2.Text +
                            ", D3=" + txtD3.Text + ", D4=" + txtD4.Text +
                            ", D5=" + txtD5.Text + ", D6=" + txtD6.Text +
                            ", D8=" + txtD8.Text + ", D9=" + txtD9.Text +
                            ", D10=" + txtD10.Text + ", D11=" + txtD11.Text +
                            " Where IdR =" + idR;
            }
            else
            {
                //insert
                retSql = "Insert Into Receptury " +
                    "(IdJFK,IdSFK,D0,D1,D2,D3,D4,D5,D6,D8,D9,D10,D11) " +
                    "Values (" + idJedlo + "," + idS + "," +
                    txtD0.Text + "," +txtD1.Text + "," +
                    txtD2.Text + "," +txtD3.Text + "," +
                    txtD4.Text + "," +txtD5.Text + "," +
                    txtD6.Text + "," +txtD8.Text + "," +
                    txtD9.Text + "," +txtD10.Text + "," +
                    txtD11.Text + ")";      
            }

            cmd = new SqlCommand(retSql, conn);
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                if(cmd.Connection.State== ConnectionState.Open) cmd.Connection.Close();
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
