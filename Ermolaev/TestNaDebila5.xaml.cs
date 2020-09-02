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

namespace Ermolaev
{
    /// <summary>
    /// Логика взаимодействия для TestNaDebila5.xaml
    /// </summary>
    public partial class TestNaDebila5 : Window
    {
        public TestNaDebila5()
        {
            InitializeComponent();
        }
        private void FirstYes_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Molodec");
            this.Close();
            TestNaDebila6 testNaDebila6 = new TestNaDebila6();
            testNaDebila6.ShowDialog();





        }

        private void FirstNo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ne Molodec");
        }

        private void FirstNox2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ne Molodec");
        }
    }
}
