using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace database
{
    /// <summary>
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Window
    {
        public Delete()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection("Data Source = ISURU; Initial Catalog = Bank; Integrated Security = True");

            cmd = new SqlCommand("Delete from Client where Client_Id='" + txt_id.Text + "'", con);

            con.Open();

            if(cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("DELETED SUCCESSFULLY");
            }
            else
            {
                MessageBox.Show("DELETEERROR");
            }
            con.Close();


        }


    }
}
