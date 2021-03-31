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

namespace Quanlyphongkham
{
    public partial class doimatkhau : Form
    {
        public doimatkhau()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string str = @"Data  =LAPTOP-GLG8I1AG\MSSQLSERVER01;Initial Catalog=QLPhongKham;Integrated Security=True";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doimatkhau_Load(object sender, EventArgs e)
        {
            if(conn == null)
            {
                conn = new SqlConnection(str);
            }
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Login";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                txtTendangnhap.Text = reader.GetString(1).Trim();
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(str);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Login";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (txtpasscu.Text == reader.GetString(2).Trim())
                {
                    reader.Close();
                    if (txtpassmoi.Text == txtxacnhanpassmoi.Text)
                    {
                        if (conn == null)
                            conn = new SqlConnection(str);
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        cmd = new SqlCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update Login set [Tài Khoản] = @Taikhoan";
                        cmd.Connection = conn;
                        cmd.Parameters.Add("@Taikhoan", SqlDbType.NChar).Value = txtpassmoi.Text;
                        int ret = cmd.ExecuteNonQuery();
                        if (ret > 0)
                        {
                            MessageBox.Show("Cập nhật mật khẩu thành công");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật mật khẩu thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn nhập xác nhận mật khẩu cũ chưa chính xác");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập mật khẩu cũ chưa chính xác");
                         }
            reader.Close();
        }
        
                }
            }
    

