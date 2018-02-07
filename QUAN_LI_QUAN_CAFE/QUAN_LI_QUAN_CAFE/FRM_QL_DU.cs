using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUAN_LI_QUAN_CAFE
{
    public partial class FRM_QL_DU : Form
    {
        public FRM_QL_DU()
        {
            InitializeComponent();
        }

        private string sqlStr;
        private DataSet ds = new DataSet();

        private void BT_E_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setEnabled(bool _bool)
        {
            txtMaDoUong.Clear();
            txtTenDoUong.Clear();
            txtDonGia.Clear();
            cbbDoTangKem.SelectedValue = "NNO";
            cbbLoaiDoUong.SelectedValue = "COKE";
            txtMaDoUong.Enabled = _bool;
            txtTenDoUong.Enabled = _bool;
            txtDonGia.Enabled = _bool;
            cbbDoTangKem.Enabled = _bool;
            cbbLoaiDoUong.Enabled = _bool;
        }

        private void FRM_QL_DU_Load(object sender, EventArgs e)
        {
            sqlStr = @"SELECT * FROM [QL_CAFE_BALCONY].[DBO].[LOAIDOUONG]";
            functions.sendDataToComboBox(cbbLoaiDoUong, ds, sqlStr, "TenLoai", "MaLoai");
            sqlStr = @"SELECT * FROM [QL_CAFE_BALCONY].[DBO].[DOTANGKEM]";
            functions.sendDataToComboBox(cbbDoTangKem, ds, sqlStr, "TenDoTangKem", "MaDoTangKem");
            sqlStr = @"SELECT * FROM [QL_CAFE_BALCONY].[dbo].[DOUONG]";
            functions.displayToGridview(dgridvDoUong, ds, sqlStr);

            setEnabled(false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setEnabled(true);
            btnAdd.Enabled = false;
            btnEdit.Text = "LƯU LẠI";
            btnDelete.Text = "HỦY BỎ";
        }

        private void themDoUong()
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                DatabaseConnection.openConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDoUong";
                cmd.Connection = DatabaseConnection.sqlCon;

                cmd.Parameters.Add("@madouong", SqlDbType.VarChar).Value = txtMaDoUong.Text;
                cmd.Parameters.Add("@tendouong", SqlDbType.NVarChar).Value = txtTenDoUong.Text;
                cmd.Parameters.Add("@loaidouong", SqlDbType.VarChar).Value = cbbLoaiDoUong.SelectedValue.ToString();
                cmd.Parameters.Add("@dotangkem", SqlDbType.VarChar).Value = cbbDoTangKem.SelectedValue.ToString();
                cmd.Parameters.Add("@dongia", SqlDbType.Money).Value = Convert.ToInt32(txtDonGia.Text);
                cmd.ExecuteNonQuery();
                functions.displayToGridview(dgridvDoUong, ds, @"SELECT * FROM [QL_CAFE_BALCONY].[dbo].[DOUONG]");
                DatabaseConnection.closeConnection();
            }
            catch (Exception mss)
            {
                functions.showMess(mss.Message);
            }
        }

        private void chinhSuaDoUong(string madouong)
        {

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "LƯU LẠI")//Trường hợp thêm mới
            {
                if (txtMaDoUong.Text == "" || txtTenDoUong.Text == "" || txtDonGia.Text == "")
                    MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        //sqlStr = @"INSERT INTO [DBO].[DOUONG](MaDoUong,TenDoUong,LoaiDoUong,DoTangKem,DonGiaDoUong) VALUES ('" +
                        //    txtMaDoUong.Text + "',N'" + txtTenDoUong.Text + "','" + cbbLoaiDoUong.SelectedValue.ToString() +
                        //    "','" + cbbDoTangKem.SelectedValue.ToString() + "'," + Convert.ToInt16(txtDonGia.Text) + ")";
                        //DatabaseConnection.RunSQLCommandNonQuery(sqlStr);
                        //functions.displayToGridview(dgridvDoUong, ds, @"SELECT * FROM [QL_CAFE_BALCONY].[dbo].[DOUONG]");
                        themDoUong();
                        setEnabled(false);

                    }
                    catch (Exception mss)
                    {
                        functions.showMess(mss.Message);
                    }
                }
                ////
                btnAdd.Enabled = true;
                btnEdit.Text = "CHỈNH SỬA ĐỒ UỐNG";
                btnDelete.Text = "XÓA ĐỒ UỐNG";
            }
            else//Trường hợp chỉnh sửa
            {
                txtMaDoUong.Text = dgridvDoUong.SelectedCells[0].ToString();
            }
        }

        private void xoaDoUong(string maDoUong)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                DatabaseConnection.openConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDoUong";
                cmd.Connection = DatabaseConnection.sqlCon;

                cmd.Parameters.Add("@madouong", SqlDbType.VarChar).Value = maDoUong;
                cmd.ExecuteNonQuery();
                functions.displayToGridview(dgridvDoUong, ds, @"SELECT * FROM [QL_CAFE_BALCONY].[dbo].[DOUONG]");
                DatabaseConnection.closeConnection();
            }
            catch (Exception mss)
            {
                functions.showMess(mss.Message);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "HỦY BỎ")
            {
                btnAdd.Enabled = true;
                btnEdit.Text = "CHỈNH SỬA ĐỒ UỐNG";
                btnDelete.Text = "XÓA ĐỒ UỐNG";
                setEnabled(false);
            }
            else//Trường hợp Xóa
            {
                try
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa đồ uống này không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        xoaDoUong(functions.selectedIndexGridView(dgridvDoUong));
                    }
                }
                catch (Exception mss)
                {
                    functions.showMess(mss.Message);
                }
            }
        }

        private void cbbLoaiDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiDoUong.SelectedValue.ToString() == "BEER")
                cbbDoTangKem.Enabled = false;
            else cbbDoTangKem.Enabled = true;
        }

    }
}
