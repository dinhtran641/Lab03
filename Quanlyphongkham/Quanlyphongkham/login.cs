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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
//xuất dòng thông báo thoát chuong trình 
            }
        }

        private void btnDN_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-GLG8I1AG\MSSQLSERVER01;Initial Catalog=QLPhongKham;Integrated Security=True");
            {
                conn.Open();
                string tk = txtTDN.Text;
                string mk = txtMK.Text;
                string sql = "select *from login  where [Tài khoản] = '" + tk + "'and [Mật khẩu] = '" + mk + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    {
                        fTableManager f = new fTableManager();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        //khi đăng nhập thành công sẽ chuyễn sang item khác
                    }

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
