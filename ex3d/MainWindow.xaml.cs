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

namespace _1730ex3d
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void searchValuesComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            valueCountTextBox.Text = "Test";
        }

        private void searchRangesComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int dashIndex = this.searchRangesComboBox.Text.IndexOf('-');
            string strSearchMin = this.searchRangesComboBox.Text.Substring(0, dashIndex).Trim();
            string strSearchMax = this.searchRangesComboBox.Text.Substring(dashIndex + 1).Trim();
            rangeCountTextBox.Text = "Test";
        }
    }
}
