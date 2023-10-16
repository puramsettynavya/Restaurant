using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectfastfood
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (UnameTb.Text == "navya" || PasswordTb.Text == "navya123")
            {
                MessageBox.Show("login sucessfull");

                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("login failes");
            }
            

        
         

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
