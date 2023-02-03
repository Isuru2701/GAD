using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Data.SqlClient;

namespace database
{
    /// <summary>
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        public Update()
        {
            InitializeComponent();
        }

        SqlConnection con; //pipeline
        SqlCommand cmd; //command 

        private void UpdateView_Loaded(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection("Data Source=ISURU;Initial Catalog=Bank;Integrated Security=True");
        }

        private void btn_update_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Update Client set Client_Name='"+txt_name.Text+"', " +
                "Client_address='"+txt_address.Text+"', " +
                "Client_DOB='"+picker_dob.DisplayDate +"', " +
                "Client_Age='" + txt_age.Text+ "', " +
                "Client_TP='" + txt_phone.Text+ "' Where Client_Id=" + txt_id.Text);

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Entry Successful");
            }
            else
            {
                MessageBox.Show("ENTRY ERROR");
            }

            con.Close();

        }

        private void picker_dob_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - picker_dob.SelectedDate.Value.Year).ToString();
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
