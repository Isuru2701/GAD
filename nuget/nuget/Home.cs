using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace nuget
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {


        public Home()
        {
            InitializeComponent();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            new Registration().Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "testing", "stub", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }
    }
}
