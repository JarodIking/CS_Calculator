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
using System.Data;

namespace CS_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator calculator;
        DataTable table = new DataTable();
        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator(DisplayTextBox, table);
        }

        private void UpdateInput(object sender, RoutedEventArgs e)
        {
            calculator.FillInput((sender as Button)?.Content?.ToString());
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.calculate();
        }
    }
}
