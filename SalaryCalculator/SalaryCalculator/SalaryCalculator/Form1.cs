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
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {

                txt_net.Text = (Convert.ToDouble(txt_basic.Text) + Convert.ToDouble(txt_allowance.Text) - (Convert.ToDouble(txt_basic.Text) * 0.1)).ToString();

            }
            catch
            {
                MessageBox.Show("Some fields are empty or contain invalid values", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_clear_Click(sender, e);
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
