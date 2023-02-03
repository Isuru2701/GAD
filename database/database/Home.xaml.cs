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

namespace database
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_registration_Click(object sender, RoutedEventArgs e)
        {
            new Registration().Show();

        }

        private void btn_update_Click(object sender, RoutedEventArgs e)
        {
            new Update().Show();
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            new Delete().Show();
        }

        private void btn_display_Click(object sender, RoutedEventArgs e)
        {
            new Display().Show();
        }
    }
}
