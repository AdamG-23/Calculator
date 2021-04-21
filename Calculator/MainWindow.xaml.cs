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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int inputNum;
        public MainWindow()
        {
            InitializeComponent();
        }

        private double result1 = 0;
        private double result2 = 0;
        bool plusBtnClicked = false;
        bool minusBtnClicked = false;
        bool multiBtnClicked = false;
        bool divideBtnClicked = false;
        bool sqrBtnClicked = false;

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtDigits.Text = "";
            btnDot.IsEnabled = true;
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            txtDigits.Text = txtDigits.Text + "1";
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            txtDigits.Text = txtDigits.Text + "2";
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            txtDigits.Text = txtDigits.Text + "3";
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            txtDigits.Text = txtDigits.Text + "4";
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            txtDigits.Text = txtDigits.Text + "5";
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            txtDigits.Text = txtDigits.Text + "6";
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            txtDigits.Text = txtDigits.Text + "7";
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            txtDigits.Text = txtDigits.Text + "8";
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            txtDigits.Text = txtDigits.Text + "9";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            //txtDigits.Text += "÷";
            result1 += double.Parse(txtDigits.Text);
            txtDigits.Text = "";

            plusBtnClicked = false;
            minusBtnClicked = false;
            multiBtnClicked = false;
            divideBtnClicked = true;
            btnDot.IsEnabled = true;
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            //txtDigits.Text = txtDigits.Text + "×";
            result1 += double.Parse(txtDigits.Text);
            txtDigits.Text = "";

            plusBtnClicked = false;
            minusBtnClicked = false;
            multiBtnClicked = true;
            divideBtnClicked = false;
            btnDot.IsEnabled = true;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            //txtDigits.Text = txtDigits.Text + "−";
            result1 += double.Parse(txtDigits.Text);
            txtDigits.Text = "";

            plusBtnClicked = false;
            minusBtnClicked = true;
            multiBtnClicked = false;
            divideBtnClicked = false;
            btnDot.IsEnabled = true;
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            //txtDigits.Text += "+";
            result1 += double.Parse(txtDigits.Text);
            txtDigits.Text = "";

            plusBtnClicked = true;
            minusBtnClicked = false;
            multiBtnClicked = false;
            divideBtnClicked = false;
            btnDot.IsEnabled = true;
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            if(plusBtnClicked == true)
            {
                result2 = result1 + double.Parse(txtDigits.Text);
                txtDigits.Text = result2.ToString();
                result1 = 0;
            }
            else if(minusBtnClicked == true)
            {
                result2 = result1 - double.Parse(txtDigits.Text);
                txtDigits.Text = result2.ToString();
                result1 = 0;
            }
            else if(multiBtnClicked == true)
            {
                result2 = result1 * double.Parse(txtDigits.Text);
                txtDigits.Text = result2.ToString();
                result1 = 0;
            }
            else if(divideBtnClicked == true)
            {
                result2 = result1 / double.Parse(txtDigits.Text);
                txtDigits.Text = result2.ToString();
                result1 = 0;
            }
            else if(sqrBtnClicked == true)
            {
                result2 = Math.Sqrt(result1);
                txtDigits.Text = result2.ToString();
                result1 = 0;
            }
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            txtDigits.Text = txtDigits.Text + "0";
        }

        private void btnNegative_Click(object sender, RoutedEventArgs e)
        {
            txtDigits.Text = "-" + txtDigits.Text;
        }

        private void btnSqrRoot_Click(object sender, RoutedEventArgs e)
        {
            result1 += double.Parse(txtDigits.Text);
            txtDigits.Text = "";

            plusBtnClicked = false;
            minusBtnClicked = false;
            multiBtnClicked = false;
            divideBtnClicked = false;
            sqrBtnClicked = true;
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            txtDigits.Text += ".";
            btnDot.IsEnabled = false;
        }
    }
}
