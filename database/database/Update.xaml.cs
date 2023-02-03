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

        }

        private void picker_dob_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - picker_dob.SelectedDate.Value.Year).ToString();
        }

    }
}
