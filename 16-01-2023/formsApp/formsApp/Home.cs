using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void txt_entry_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            //DialogResult ans = MessageBox.Show("Hello!\nClose this message?", "InfoBox", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //if (ans == DialogResult.Cancel)
            //{
            //    MessageBox.Show("Done");
            //}


            //fetches the value in the txt_entry box
            lbl_display.Text = "Hi, " + txt_entry.Text;        
           
        }
    }
}