using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QUAN_LI_QUAN_CAFE
{
    class DatabaseConnection
    {
        public static SqlConnection sqlCon = new SqlConnection();
        public static string ConnectionString = @"Data Source=INSPIRON7559;Initial Catalog=QL_CAFE_BALCONY;Integrated Security=True";

        public static void openConnection()
        {
            try
            {
                sqlCon = new SqlConnection(ConnectionString);
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Open && sqlCon != null)
                    sqlCon.Close();
            }
            catch
            { }
        }

        public static object RunSQLCommandNonQuery(string strSQL)
        {
            object obj = new object();
            try
            {
                openConnection();
                SqlCommand sqlCmd = new SqlCommand(strSQL, sqlCon);
                obj = sqlCmd.ExecuteNonQuery();
                closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return obj;
        }

        public static object RunSQLCommandScalar(string strSQL)
        {
            object obj = new object();
            try
            {
                openConnection();
                SqlCommand sqlCmd = new SqlCommand(strSQL, sqlCon);
                obj = sqlCmd.ExecuteScalar();
                closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return obj;
        }

        public static SqlDataReader RunSQLCommandReader(string strSQL)
        {
            SqlDataReader obj = null;
            try
            {
                openConnection();
                SqlCommand sqlCommand = new SqlCommand(strSQL, sqlCon);
                obj = sqlCommand.ExecuteReader();
                closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return obj;
        }

        public static DataSet GetDataSet(string strSQL)
        {
            DataSet dt = new DataSet();
            try
            {
                openConnection();
                SqlDataAdapter sqlDA = new SqlDataAdapter(strSQL, sqlCon);
                sqlDA.Fill(dt);
                closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dt;
        }

        public static void executeSqlProcedure(string str)
        {
            SqlCommand Cmd = new SqlCommand();
            try
            {
                openConnection();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = str;
                Cmd.Connection = sqlCon;
            }
            catch(Exception mss)
            {
                MessageBox.Show(mss.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
