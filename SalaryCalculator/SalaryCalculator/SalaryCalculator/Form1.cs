using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class Form1 : Form

    {
        double basic, allowance, epf;

        public Form1()
        {
            InitializeComponent();
        }


        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                basic = Convert.ToDouble(txt_basic.Text);
                allowance = Convert.ToDouble(txt_allowance.Text);

                epf = basic * 0.1;
                txt_net.Text = Convert.ToString(basic + allowance - epf);

            }
            catch
            {
                MessageBox.Show("Some fields are empty or contain invalid values", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_basic.Clear();
            txt_allowance.Clear();
            txt_net.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Exit calculator?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
