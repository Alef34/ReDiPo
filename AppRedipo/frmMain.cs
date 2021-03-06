﻿using System;
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
    public partial class frmMain : Form
    {

        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection("Data Source=USER-02-C2\\SQLEXPRESS;Integrated Security=False;Initial Catalog=Redipo; User ID=sa;Password=;Pooling=False");
        SqlCommand cmd;
        string retSql = "";


        public frmMain()
        {
            InitializeComponent();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            UkonciProgram();
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

           // retSql = "Select * from Jedla";
            cmd = new SqlCommand(retSql, conn);
            cmd.CommandType = CommandType.Text;
            DA.SelectCommand = cmd;
            if (DS.Tables["Jedla"] != null) DS.Tables["Jedla"].Clear();
            DA.Fill(DS, "Jedla");

           // dataGridView1.DataSource = DS.Tables["Jedla"];
        }

        private void TxtFilterS_TextChanged(object sender, EventArgs e)
        {
            DataView dv = DS.Tables["Jedla"].DefaultView;
            dv.RowFilter = "Surovina like '%" + txtFilterS.Text + "%' ";
            txtFilterCount.Text = dv.Count.ToString();
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

        private void ChladnickaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChladnicka frmChlad = new frmChladnicka();
            frmChlad.StartPosition = FormStartPosition.CenterScreen;
            frmChlad.ShowDialog();
            frmChlad.Dispose();
        }

        private void KoniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ToolStripButton1_Click(sender, e);
            UkonciProgram();
        }

        private void UkonciProgram()
        {
           this.Close();
        }

        private void JedlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJedla frmJed = new frmJedla();
            frmJed.StartPosition = FormStartPosition.CenterScreen;
            frmJed.ShowDialog();
            frmJed.Dispose();
        }

        private void KategorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategorie frmKateg = new frmKategorie();
            frmKateg.StartPosition = FormStartPosition.CenterScreen;
            frmKateg.ShowDialog();
            frmKateg.Dispose();
        }

        private void SurovinyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuroviny frmSurov = new frmSuroviny();
            frmSurov.StartPosition = FormStartPosition.CenterScreen;
            frmSurov.ShowDialog();
            frmSurov.Dispose();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            frmSuroviny frmSurov = new frmSuroviny();
            frmSurov.StartPosition = FormStartPosition.CenterScreen;
            frmSurov.ShowDialog();
            frmSurov.Dispose();
        }
    }
}
