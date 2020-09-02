using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для TestNaDebila6.xaml
    /// </summary>
    public partial class TestNaDebila6 : Window
    {
        public TestNaDebila6()
        {
            InitializeComponent();
        }
        private void FirstYes_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Molodec, Ty proshel nash Test");
            //----Только не удаляйте пж((
            Process.Start("https://dp.vgorode.ua/reference/psykhoterapyia/101124-dnepropetrovskaia-klynycheskaia-psykhyatrycheskaia-bolnytsa");

            this.Close();
            





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
