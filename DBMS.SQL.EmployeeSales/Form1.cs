
using Microsoft.Data.SqlClient;
using System.Data;

namespace DBMS.SQL.EmployeeSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ประกาศตัวแปร connect 
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void connectDB()
        {
            string server = @"LAPTOP-7KNTOGM4\SQLEXPRESS02";
            string db = "Northwind";
            string strCon = string.Format(@"Data Source={0}; Initial Catalog={1};"
                      + "Integrated Security=True;Encrypt=False", server, db);
            /*string strCon = "Data Source=LAPTOP-7KNTOGM4\\SQLEXPRESS02;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False";*/
            conn = new SqlConnection(strCon);
            conn.Open();
        }
        private void disconnectDB()
        {
            conn.Close();
        }
        private void showdata(string sql, DataGridView dgv)
        {
            da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            connectDB();
            string sqlQuery = "select * from EmployeeList";
            showdata(sqlQuery, dgvEmployeeList);
        }

        private void dgvEmployeeList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                {
                    int id = Convert.ToInt32(dgvEmployeeList.CurrentRow.Cells[0].Value);
                    string sqlQuery = "select * from OrderList";
                    cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvOrderList.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
