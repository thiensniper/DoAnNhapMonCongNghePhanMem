using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace QUAN_LI_QUAN_CAFE
{
    class functions
    {
        public static void showMess(string str)
        {
            MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK);
        }

        public static void displayToGridview(DataGridView dtgv, DataSet dset, string str)//Hiển thị dữ liệu đến DataGridView
        {
            dset = DatabaseConnection.GetDataSet(str);
            dtgv.DataSource = dset.Tables[0];
        }

        public static void sendDataToComboBox(ComboBox cbb, DataSet dset, string str, string displayMember, string valueMember)//Truyền dữ liệu đến ComboBox
        {
            dset = DatabaseConnection.GetDataSet(str);
            cbb.DataSource = dset.Tables[0];
            cbb.DisplayMember = displayMember;
            cbb.ValueMember = valueMember;
        }

        public static string selectedIndexGridView(DataGridView dgv)
        {
            try
            {
                string ma = null;
                if (dgv.SelectedRows.Count == 0) return null;
                DataGridViewRow temp = dgv.Rows[dgv.SelectedRows[0].Index];
                ma = temp.Cells[0].Value.ToString();
                return ma;
            }
            catch (Exception mss)
            {
                showMess(mss.Message);
                return null;
            }
        }
    }
}
