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

namespace Ermolaev
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //GayTest taskWindow = new GayTest();
            //taskWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TestNaDebila taskWindow = new TestNaDebila();
            taskWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CoiTest taskWindow = new CoiTest();
            taskWindow.Show();
        }
    }
}
