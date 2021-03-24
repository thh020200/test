using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "admin";
            if (user.Equals(txtUsername.Text) && pass.Equals(txtPassword.Text))
            {
                MessageBox.Show("Đăng nhạp thành công!");
                Form2 form2 =new Form2();
                form2.ShowDialog();
                this.Close();
               
            }
            else
                MessageBox.Show("Đăng nhập thất bại!");

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
