using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRedipo
{
    public partial class frmReceptura : Form
    {

        private int idJedlo;


        public frmReceptura(int idjedlo)
        {
            InitializeComponent();
            idJedlo = idjedlo;
        }

        private void BtnZatvor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmReceptura_Load(object sender, EventArgs e)
        {
            lblId.Text = idJedlo.ToString();
        }
    }
}
