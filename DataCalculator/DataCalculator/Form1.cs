using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_day.Clear();
            txt_night.Clear();
            lbl_total.Text = "Rs. 0.00";
            rad_day.Checked = false;
            rad_night.Checked = false;
        }

        

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                // if type == Day_Blast
                if (rad_day.Checked)
                    lbl_total.Text = "Rs. " + Package.CalDayBlast(Convert.ToDouble(txt_day.Text), Convert.ToDouble(txt_night.Text));

                //if type == Night_Blast
                else if (rad_night.Checked)
                    lbl_total.Text = "Rs. " + Package.CalNightBlast(Convert.ToDouble(txt_day.Text), Convert.ToDouble(txt_night.Text));

                else MessageBox.Show("Please select a package", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch
            {
                MessageBox.Show("A field is empty or contains non-numeric characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }


}
