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
            lbl_total.Text = "";
        }

        

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double dayUse = 0, nightUse = 0;
            //fetch amounts consumed
            try
            {
                dayUse = Convert.ToDouble(txt_day.Text);
                nightUse = Convert.ToDouble(txt_night.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Characters entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // if type == Day_Blast
            if (rad_day.Checked)
                Package.CalDayBlast(dayUse, nightUse);

            //if type == Night_Blast
            else if (rad_night.Checked)
                Package.CalNightBlast(dayUse, nightUse);   

            lbl_total.Text = "Rs. " + Package.Total.ToString(); 

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
