using System;
using System.Collections.Generic;
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

using System.Data.SqlClient; //ADO.net Class library

namespace database
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        SqlConnection con; //pipeline
        SqlCommand cmd; //command 

        private void RegistrationView_Loaded(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection("Data Source=ISURU;Initial Catalog=Bank;Integrated Security=True");
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
                con.Open();

            //string interpolation is better here

            cmd = new SqlCommand("Insert into Client Values('" +txt_id.Text +"','"+
                txt_name.Text+"','"+txt_address.Text+
                "', '"+picker_dob.DisplayDate+
                "', '"+txt_age.Text+"'," +
                "'"+txt_phone.Text+"')", con);

                //the painful way:
                //cmd = new SqlCommand("INSERT INTO BANK VALUES (@a, @b, @c, @d, @e, @f)", con);

                //cmd.Parameters.AddWithValue("a", txt_id.Text);
                //cmd.Parameters.AddWithValue("b", txt_name.Text);
                //cmd.Parameters.AddWithValue("c", txt_address.Text);
                //cmd.Parameters.AddWithValue("d", picker_dob.DisplayDate);
                //cmd.Parameters.AddWithValue("e", Convert.ToInt32(txt_age.Text));
                //cmd.Parameters.AddWithValue("f", Convert.ToInt32(txt_phone.Text));

                if(cmd.ExecuteNonQuery() == 1)
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
    }
}
