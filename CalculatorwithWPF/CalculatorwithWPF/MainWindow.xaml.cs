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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorwithWPF
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

        private int fetch_decimal()
        {
            return (int)slr_decimal.Value;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lbl_ans.Content = Math.Round(Convert.ToDouble(txt_num1.Text) + Convert.ToDouble(txt_num2.Text), fetch_decimal()).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error, please enter numeric values", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_sub_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lbl_ans.Content = Math.Round(Convert.ToDouble(txt_num1.Text) - Convert.ToDouble(txt_num2.Text), fetch_decimal()).ToString() ;
            }
            catch (FormatException)
            {
                MessageBox.Show("Error, please enter numeric values", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_mul_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lbl_ans.Content = Math.Round(Convert.ToDouble(txt_num1.Text) * Convert.ToDouble(txt_num2.Text), fetch_decimal()).ToString();

            }
            catch (FormatException)
            {

                MessageBox.Show("Error, please enter numeric values", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_div_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lbl_ans.Content = Math.Round(Convert.ToDouble(txt_num1.Text) / Convert.ToDouble(txt_num2.Text), fetch_decimal()).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error, please enter numeric values", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            txt_num1.Clear();
            txt_num2.Clear();
            lbl_ans.Content = "--";
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
