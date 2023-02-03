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
    }
}
