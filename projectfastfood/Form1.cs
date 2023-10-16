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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BurgerTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void FriesTb_TextChanged(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            Date1b1.Text = DateTime.Now.ToLongTimeString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Date1b1.Text = DateTime.Now.ToLongDateString();
            timer.Start();
        }

        private void FriesCh_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCb.Checked == true)
            {
                FriesTb.Enabled = true;
            }
            if (FriesCb.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerTb.Enabled = true;
            }
            if (BurgerCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";

            }
        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladTb.Enabled = true;
            }
            if (SaladCb.Checked == false)
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }
        }

        private void SandwishCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwishCb.Checked == true)
            {
                SandwishTb.Enabled = true;
            }
            if (SandwishCb.Checked == false)
            {
                SandwishTb.Enabled = false;
                SandwishTb.Text = "0";
            }
        }

        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCb.Checked == true)
            {
                ChickenTb.Enabled = true;
            }
            if (ChickenCb.Checked == false)
            {
                ChickenTb.Enabled = false;
                ChickenTb.Text = "0";
            }
        }

        private void CheeseCb_CheckedChanged(object sender, EventArgs e)
        {

            if (CheeseCb.Checked == true)
            {
                CheeseTb.Enabled = true;
            }
            if (CheeseCb.Checked == false)
            {
                CheeseTb.Enabled = false;
                CheeseTb.Text = "0";
            }
        }


        private void Close1b1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCb.Checked == true)
            {
                TeaTb.Enabled = true;
            }
            if (TeaCb.Checked == false)
            {
                TeaTb.Enabled = false;
                TeaTb.Text = "0";
            }
        }

        private void ColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCb.Checked == true)
            {
                ColaTb.Enabled = true;
            }
            if (ColaCb.Checked == false)
            {
                ColaTb.Enabled = false;
                ColaTb.Text = "0";
            }
        }

        private void BottleWaterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BottleWaterCb.Checked == true)
            {
                BottleWaterTb.Enabled = true;
            }
            if (BottleWaterCb.Checked == false)
            {
                BottleWaterTb.Enabled = false;
                BottleWaterTb.Text = "0";
            }
        }

        private void ChocolateCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateCb.Checked == true)
            {
                ChocolateTb.Enabled = true;
            }
            if (ChocolateCb.Checked == false)
            {
                ChocolateTb.Enabled = false;
                ChocolateTb.Text = "0";
            }
        }

        private void PancakesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PancakesCb.Checked == true)
            {
                PancakesTb.Enabled = true;
            }
            if (PancakesCb.Checked == false)
            {
                PancakesTb.Enabled = false;
                PancakesTb.Text = "0";
            }
        }

        private void JuicesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (JuicesCb.Checked == true)
            {
                JuicesTb.Enabled = true;
            }
            if (JuicesCb.Checked == false)
            {
                JuicesTb.Enabled = false;
                JuicesTb.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FriesCb.Checked = false;
            BurgerCb.Checked = false;
            SaladCb.Checked = false;
            ChickenCb.Checked = false;
            CheeseCb.Checked = false;
            SandwishCb.Checked = false;

            TeaCb.Checked = false;
            ColaCb.Checked = false;
            ChocolateCb.Checked = false;
            BottleWaterCb.Checked = false;
            PancakesCb.Checked = false;
            JuicesCb.Checked = false;

            ReceiptTb.Clear();

            MessageBox.Show("Reset Successfully");
            
            
            
            

        }
        // Declare until price to differnt meal and drinks
        

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void label15_Click(object sender, EventArgs e)
        {

        }
        double friesup = 50, burgerup = 80, saladup = 100, sandwichup = 75, chickenup = 165, cheeseup = 50;

        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
            MessageBox.Show("print successful");
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTb.Text+"\n \t Subtotal \t"+subtotal1b1.Text+"\tTax:\t "+tax1b1.Text+"\tGround Total \t"+gridtotal1b1.Text,new Font("Century Gothic", 12, FontStyle.Regular),Brushes.Blue,new Point(130));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            items form = new items();
            form.Show();
            this.Hide();
        }

        double waterup = 15, colaup = 20, chocolateup = 25, pancakesup = 25, juicesup = 50, teaup = 15;
        double friestp, burgertp, saladtp, sandwichtp, cheesetp, watertp, colatp, chocolatetp, pancakestp, juicestp, teatp, chickentp;
        double subtotal = 0;

       

        //declare variables 
        private void button2_Click(object sender, EventArgs e)
        {
            chickentp = chickenup * Convert.ToDouble(ChickenTb.Text);
            friestp = friesup * Convert.ToDouble(FriesTb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTb.Text);
            saladtp = saladup * Convert.ToDouble(SaladTb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwishTb.Text);
            cheesetp = cheeseup * Convert.ToDouble(CheeseTb.Text);

            // let do the same for drinks
            watertp = waterup * Convert.ToDouble(BottleWaterTb.Text);
            
            colatp = colaup * Convert.ToDouble(ColaTb.Text);
            chocolatetp = chocolateup * Convert.ToDouble(ChocolateTb.Text);
            pancakestp = pancakesup * Convert.ToDouble(PancakesTb.Text);
            juicestp = juicesup * Convert.ToDouble(JuicesTb.Text);
           

            //now lets the ass products on the receipt

            ReceiptTb.Clear();
            double tax;
            double grdtotal;
            subtotal = 0;

            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t\tFAST N FRESH RESTAURENT\t\t"+ Date1b1.Text +Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t\t*************************"+Environment.NewLine);
            if(FriesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tfries:\t" + friestp + "Rs" + Environment.NewLine);
                subtotal = subtotal + friestp;
                subtotal1b1.Text = "" + subtotal;
            }

            if (BurgerCb.Checked == true)
            {
                ReceiptTb.AppendText("\tburger:\t" + burgertp + "Rs" + Environment.NewLine);
                subtotal = subtotal + burgertp;
                subtotal1b1.Text = "" + subtotal;

            }

            if (SaladCb.Checked == true)
            {
                ReceiptTb.AppendText("\tsalad:\t" + saladtp + "Rs" + Environment.NewLine);
                subtotal = subtotal + saladtp;
                subtotal1b1.Text = "" + subtotal;


            }

            if (SandwishCb.Checked == true)
            {
                ReceiptTb.AppendText("\tsandwich:\t" + sandwichtp + "Rs" + Environment.NewLine);
                subtotal = subtotal + sandwichtp;
                subtotal1b1.Text = "" + subtotal;

            }

            if (CheeseCb.Checked == true)
            {
                ReceiptTb.AppendText("\tcheese:\t" + cheesetp + "Rs" + Environment.NewLine);
                subtotal = subtotal + cheesetp;
                subtotal1b1.Text = "" + subtotal;
            }

            if (ChickenCb.Checked == true)
            {
                ReceiptTb.AppendText("\tchiken:\t" + chickentp + "Rs" + Environment.NewLine);
                subtotal = subtotal + chickentp;
                subtotal1b1.Text = "" + subtotal;
            }

            // let do the same for the drinks and dessert

            if (TeaCb.Checked == true)
            {
                ReceiptTb.AppendText("\ttea:\t" + teatp + "Rs" + Environment.NewLine);
                subtotal = subtotal + teatp;
                subtotal1b1.Text = "" + subtotal;

            }

            if (ColaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tcola:\t" + colatp + "Rs" + Environment.NewLine);
                subtotal = subtotal + colatp;
                subtotal1b1.Text = "" + subtotal;
            }

            if (BottleWaterCb.Checked == true)
            {
                ReceiptTb.AppendText("\twaterbottles:\t" + watertp + "Rs" + Environment.NewLine);
                subtotal = subtotal + watertp;
                subtotal1b1.Text = "" + subtotal;
            }


            if (ChocolateCb.Checked == true)
            {
                ReceiptTb.AppendText("\tchocolates:\t" + chocolatetp + "Rs" + Environment.NewLine);
                subtotal = subtotal + chocolatetp;
                subtotal1b1.Text = "" + subtotal;
            }

            if (PancakesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tpancakes:\t" + pancakestp + "Rs" + Environment.NewLine);
                subtotal = subtotal + pancakestp;
                subtotal1b1.Text = "" + subtotal;
            }

            if (JuicesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tjuices:\t" + juicestp + "Rs" + Environment.NewLine);
                subtotal = subtotal + juicestp;
                subtotal1b1.Text = "" + subtotal;
            }
           


            tax = subtotal * 0.16;
            grdtotal = subtotal + tax;
            tax1b1.Text = "Rs" + tax;
            gridtotal1b1.Text = "Rs" + grdtotal;


            MessageBox.Show("added successfully");









        }

        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {

        }
    }

}


        