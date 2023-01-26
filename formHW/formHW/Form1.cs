using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formHW
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog select = new OpenFileDialog();

            try
            {
                if (select.ShowDialog() == DialogResult.OK)
                {
                    pic_pfp.Image = Image.FromFile(select.FileName);
                }
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("file is not an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("image was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (ArgumentException)
            {
                MessageBox.Show("invalid file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("invalid image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
