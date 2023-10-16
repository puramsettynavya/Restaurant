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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView1.Show();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fnfDataSet2.manage_items' table. You can move, or remove it, as needed.
            this.manage_itemsTableAdapter.Fill(this.fnfDataSet2.manage_items);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            items form = new items();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Delete successfully");
        }
    }
}
