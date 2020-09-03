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
    /// Interaction logic for WhyAreYouGay.xaml
    /// </summary>
    public partial class WhyAreYouGay : Window
    {
        string answer;
        int gayMetr = 0;
        int questionNum = 1;
        public WhyAreYouGay()
        {
            InitializeComponent();
        }

        public void Update()
        {
            questionNum++;
            switch (questionNum)
            {
                case 2:
                    {
                        question.Content = "На какой стул сядешь?";
                        btnMinus.Content = "с пиками";
                        btnPlus.Content = "не с пиками";
                        break;
                    }
                case 3:
                    {
                        question.Content = "бибер секси?";
                        btnMinus.Content = "больной ублюдок";
                        btnPlus.Content = "дыа";
                        break;
                    }
                case 4:
                    {
                        question.Content = "лечил геморой огурцами?";
                        btnMinus.Content = "ты вообще адекватный";
                        btnPlus.Content = "дыа";
                        break;
                    }
                case 5:
                    {
                        question.Content = "любишь лечиться свечами?";
                        btnMinus.Content = "я сейчас в дурку позвоню";
                        btnPlus.Content = "дыа";
                        break;
                    }
                case 6:
                    {
                        question.Content = "любишь яблочный мартини?";
                        btnMinus.Content = "самый гейский напиток в баре";
                        btnPlus.Content = "дыа";
                        break;
                    }
                case 7:
                    {
                        if (gayMetr < -3)
                            answer = "u rnt gay";
                        else if (gayMetr > 3)
                            answer = "u r gay";
                        else
                            answer = "u r norm";

                        MessageBox.Show(answer);
                        break;
                    }

            }
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            gayMetr++;
            Update();
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            gayMetr--;
            Update();
        }
    }
}

