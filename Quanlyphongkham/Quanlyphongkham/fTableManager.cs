using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyphongkham
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                thuoc t = new thuoc();
                this.Hide();
                t.ShowDialog();
                this.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cauhinh c = new cauhinh();
            c.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cauhinh c = new cauhinh();
            c.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bacsi b = new bacsi();
            b.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bacsi b = new bacsi();
            b.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            thuoc t = new thuoc();
            t.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            benhnhan bn = new benhnhan();
            bn.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            khambenh k = new khambenh();
            k.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            benhnhan bn = new benhnhan();
            bn.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            khambenh k = new khambenh();
            k.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timkiembenhnhan t = new timkiembenhnhan();
            t.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timkiemlichhen tk = new timkiemlichhen();
            tk.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            timkiemlichhen tk = new timkiemlichhen();
            tk.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            timkiembenhnhan t = new timkiembenhnhan();
            t.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            doimatkhau dmk = new doimatkhau();
            dmk.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            doimatkhau dmk = new doimatkhau();
            dmk.ShowDialog();
        }
    }
}
