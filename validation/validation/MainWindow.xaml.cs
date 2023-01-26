using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace validation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            if (txt_fname.Text.Length == 0 || txt_fname.Text.Any(char.IsDigit))
            {
                lbl_error.Content = "first name cannot be empty or cannot contain numbers";
            }
            else if (txt_lname.Text.Length == 0 || txt_lname.Text.Any(char.IsDigit))
            {
                lbl_error.Content = "last name cannot be empty or cannot contain numbers";
            }
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                lbl_error.Content = "email is invalid, please try again";
            }
            else if (pwb_password.Password.Length <= 6)
            {
                lbl_error.Content = "Password cannot be less than 6 characters";
            }
            else if (pwb_confirm_password.Password != pwb_password.Password)
            {
                lbl_error.Content = "Password and confirmation do not match";
            }

            else if (string.IsNullOrEmpty(txt_address.Text))
            {
                lbl_error.Content = "address cannot be empty";

            }
            else if (string.IsNullOrEmpty(txt_telephone.Text) || txt_telephone.Text.Length != 10 || !Regex.IsMatch(txt_telephone.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                lbl_error.Content = "telephone number is invalid";
            }
            else
            {
                lbl_error.Content = "";
            }

        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_address.Clear();
            txt_email.Clear();
            txt_telephone.Clear();
            pwb_password.Clear();
            pwb_confirm_password.Clear();

        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}