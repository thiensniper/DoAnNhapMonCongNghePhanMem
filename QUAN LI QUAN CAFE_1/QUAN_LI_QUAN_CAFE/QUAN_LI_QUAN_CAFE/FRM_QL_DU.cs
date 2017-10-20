using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LI_QUAN_CAFE
{
    public partial class FRM_QL_DU : Form
    {
        public FRM_QL_DU()
        {
            InitializeComponent();
        }

        private void BT_E_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_QL_DU_Load(object sender, EventArgs e)
        {
            GB_2.Hide();
        }

        private void BT_THEM_Click(object sender, EventArgs e)
        {
            GB_2.Show();
        }

        private void BT_SUA_Click(object sender, EventArgs e)
        {
            GB_2.Show();
        }

        private void BT_XOA_Click(object sender, EventArgs e)
        {
            GB_2.Show();
        }
    }
}
