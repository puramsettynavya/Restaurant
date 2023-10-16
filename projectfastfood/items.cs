
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
 

namespace projectfastfood
{
    
    public partial class items : Form
        
    {
        public items()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            categoriesTb.Items.Add(CatTb.Text);
            MessageBox.Show("Category added successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

           
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            ViewOrders form = new  ViewOrders();
            form.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
            MessageBox.Show("logout successfull");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void items_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fnfDataSet1.manage_items' table. You can move, or remove it, as needed.
            this.manage_itemsTableAdapter1.Fill(this.fnfDataSet1.manage_items);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(nameTb.Text == "" || categoriesTb.Text == "" || priceTb.Text =="" || quantityTb.Text =="" )
            {
                MessageBox.Show("please fill all details");

            }
            else
            {
                string connectionstring;
                SqlConnection con;
                connectionstring = @"SERVER=MSI\SQLEXPRESS;DATABASE= fnf;Integrated security = true; ";
                con = new SqlConnection(connectionstring);
                con.Open();
                String query = "insert into manage_items values('" + nameTb.Text.ToString() + "','" + categoriesTb.Text.ToString() + "','" + priceTb.Text.ToString() + "','" + quantityTb.Text.ToString() + "')";
                
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
     
                con.Close();
               
                      
                MessageBox.Show("item added successfully");
               
                

               


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Close1b1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
              