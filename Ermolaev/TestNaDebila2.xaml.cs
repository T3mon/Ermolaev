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
    /// Логика взаимодействия для TestNaDebila2.xaml
    /// </summary>
    public partial class TestNaDebila2 : Window
    {
        public TestNaDebila2()
        {
            InitializeComponent();

            
        }
        private void FirstYes_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Molodec");
            this.Close();
            TestNaDebila3 testNaDebila3 = new TestNaDebila3();
            testNaDebila3.ShowDialog();





        }

        private void FirstNo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ne Molodec");
        }
    }
}
