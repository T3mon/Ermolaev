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
    /// Логика взаимодействия для TestNaDebila4.xaml
    /// </summary>
    public partial class TestNaDebila4 : Window
    {
        public TestNaDebila4()
        {
            InitializeComponent();
        }
        private void FirstYes_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Molodec");
            this.Close();
            TestNaDebila5 testNaDebila5 = new TestNaDebila5();
            testNaDebila5.ShowDialog();





        }

        private void FirstNo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ne Molodec");
        }
    }
}
