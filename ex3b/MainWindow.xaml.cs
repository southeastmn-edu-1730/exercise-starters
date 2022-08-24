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

namespace _1730ex3b
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

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            //  0) GetDiscountPercent(subtotal)
            try
            {
                decimal subtotal = Decimal.Parse(this.inputTextBox0a.Text);
                this.resultTextBox0.Text = Ex3bCalculations.GetDiscountPercent(subtotal).ToString("f3");
            }
            catch
            {
                this.resultTextBox0.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox0a.Text);
            }

            //  1) GetDiscountPercent(subtotal, out decimal discountPercent)
            try
            {
                decimal subtotal = Decimal.Parse(this.inputTextBox1a.Text);
                decimal discountPercent = 0m;
                Ex3bCalculations.GetDiscountPercent(
                    subtotal, out discountPercent);
                this.resultTextBox1.Text = discountPercent.ToString("f3");
            }
            catch
            {
                this.resultTextBox1.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox1a.Text);
            }

            // 2) CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months)
            try
            {
                int months = Int32.Parse(this.inputTextBox2a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTextBox2b.Text);
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextBox2c.Text);
                this.resultTextBox2.Text = Ex3bCalculations.CalculateFutureValue(
                    monthlyInvestment, monthlyInterestRate, months).ToString("c2");
            }
            catch
            {
                this.resultTextBox2.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox2a.Text + "\n"
                    + this.inputTextBox2b.Text + "\n"
                    + this.inputTextBox2c.Text + "\n");
            }

            // 3) CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months, ref futureValue)
            try
            {
                int months = Int32.Parse(this.inputTextBox3a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTextBox3b.Text);
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextBox3c.Text);
                decimal futureValue = 0m;
                Ex3bCalculations.CalculateFutureValue
                    (monthlyInvestment, monthlyInterestRate, months, ref futureValue);
                this.resultTextBox3.Text = futureValue.ToString("c2");
            }
            catch
            {
                this.resultTextBox3.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox3a.Text + "\n"
                    + this.inputTextBox3b.Text + "\n"
                    + this.inputTextBox3c.Text + "\n");
            }

            //  4) FahrenheitToCelsius(fahrenheit)
            try
            {
                double fahrenheit = Double.Parse(this.inputTextBox4a.Text);
                this.resultTextBox4.Text = Ex3bCalculations.FahrenheitToCelsius(fahrenheit).ToString("f1");
            }
            catch
            {
                this.resultTextBox4.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox4a.Text);
            }

            //  5) CelsiusToFahrenheit(celsius, out fahrenheit)
            try
            {
                double celsius = Double.Parse(this.inputTextBox5a.Text);
                Ex3bCalculations.CelsiusToFahrenheit(celsius, out double fahrenheit);
                this.resultTextBox5.Text = fahrenheit.ToString("f1");
            }
            catch
            {
                this.resultTextBox5.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox5a.Text);
            }

            //  6) GrossPay(hours, rate)
            try
            {
                decimal hours = Decimal.Parse(this.inputTextBox6a.Text);
                decimal rate = Decimal.Parse(this.inputTextBox6b.Text);
                this.resultTextBox6.Text = Ex3bCalculations.GrossPay(hours, rate).ToString("c2");
            }
            catch
            {
                this.resultTextBox6.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox6a.Text + "\n"
                    + this.inputTextBox6b.Text);
            }

            //  7) TotalHours(strNumbers)
            try
            {
                this.resultTextBox7.Text =
                    Ex3bCalculations.TotalHours(this.inputTextBox7a.Text).ToString("n2");
            }
            catch
            {
                this.resultTextBox7.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox7a.Text);
            }

            //  8) GrossPay(strNumbers, rate)
            try
            {
                decimal rate = Decimal.Parse(this.inputTextBox8b.Text);
                this.resultTextBox8.Text =
                    Ex3bCalculations.GrossPay(this.inputTextBox8a.Text, rate).ToString("c2");
            }
            catch
            {
                this.resultTextBox8.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox8a.Text + "\n"
                    + this.inputTextBox8b.Text);
            }
        }
    }
}
