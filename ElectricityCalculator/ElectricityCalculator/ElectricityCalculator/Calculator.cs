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
            try
            {
                if (rad_business.Checked)
                {

                    BusinessCustomer.Units = Convert.ToDouble(txt_units.Text);
                    lbl_amount.Text = "Rs. " + (new BusinessCustomer().CalculateBill()).ToString();
                }
                else if (rad_domestic.Checked)
                {
                    DomesticCustomer.Units = Convert.ToDouble(txt_units.Text);
                    lbl_amount.Text = "Rs. " + (new DomesticCustomer().CalculateBill()).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Invalid value. Please retry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Calculator?", "exit confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_units.Clear();
            lbl_amount.Text = "Rs. 0.00";
        }

    }

    internal abstract class Customer
    {
        public static double Units { get; set; }
        abstract public double CalculateBill();
    }

    internal class DomesticCustomer : Customer
    {
        public override double CalculateBill()
        {
            //starts off with the rental amount + first 100 units (Rs 200 + 500)
            if (Units <= 100) return 700;

            //20 per additional (Unit > 100)
            else return 700 + ((Units - 100) * 20);


        }
    }
    internal class BusinessCustomer : Customer
    {
        public override double CalculateBill()
        {
            //starts off with the rental amount + first 100 units (Rs 600 + 800)
            if (Units <= 100) return 1400;

            //20 per additional (Unit > 100)
            else return 1400 + ((Units - 100) * 50);

        }
    }
}