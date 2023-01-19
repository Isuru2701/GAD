using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricityCalculator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if (rad_business.Checked)
            {

                try
                {
                    BusinessCustomer.Units = Convert.ToDouble(txt_units.Text);
                    lbl_amount.Text = "Rs. " + (new BusinessCustomer().CalculateBill()).ToString();
                }
                catch 
                {
                    MessageBox.Show("Invalid characters entered. Please retry.");
                }
            }
            else if (rad_domestic.Checked)
            {
                try
                {
                    DomesticCustomer.Units = Convert.ToDouble(txt_units.Text);
                    lbl_amount.Text = "Rs. " + (new DomesticCustomer().CalculateBill()).ToString();
                }
                catch
                {
                    MessageBox.Show("Invalid characters entered. Please retry.");
                }
            }
        }
    }

    internal abstract class Customer
    {
        public static double Units { get; set; }
        public static double Amount { get; set; }

        abstract public double CalculateBill();
    }

    internal class DomesticCustomer : Customer
    {
        public override double CalculateBill()
        {
            //starts off with the rental amount + first 100 units (Rs 200 + 500)
            Amount = 700;
            //20 per additional (Unit > 100)
            if (Units > 100)
            {
                Amount += ((Units - 100) * 20);
            }

            return Amount;
        }
    }

    internal class BusinessCustomer : Customer
    {
        public override double CalculateBill()
        {
            //starts off with the rental amount + first 100 units (Rs 600 + 800)
            Amount = 1400;
            //50 per additional (Unit > 100)
            if (Units > 100)
            {
                Amount += ((Units - 100) * 50);
            }

            return Amount;
        }
    }

}