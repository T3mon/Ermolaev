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
    /// Interaction logic for CoiTest.xaml
    /// </summary>
    public partial class CoiTest : Window
    {
        private List<Question> questions = new List<Question>();
        User user = new User();

        internal List<Question> Questions { get => questions; set => questions = value; }

        public CoiTest()
        {
            InitializeComponent();
            Questions.Add(
                new Question
                {
                    QuestionNumber = 1,
                    _Question = "Какие огурцы сажал певец на брезентовом поле?",
                    Answer1 = "железные",
                    Answer2 = "алюминевые",
                    Answer3 = "каменные",
                    Correct = 2
                });
            Questions.Add(
                 new Question
                 {
                     QuestionNumber = 2,
                     _Question = "Название КИНО появилось потом.\nА вначале группа Виктора Цоя, Алексея Рыбина и Олега Валинского называлась...? ",
                     Answer1 = "Гарин и гиперболоиды",
                     Answer2 = "Автоматические удовлетворители",
                     Answer3 = "Странные игры",
                     Correct = 1
                 });
            Questions.Add(
                  new Question
                  {
                      QuestionNumber = 3,
                      _Question = "Мало кто знает, но впервые молодой Виктор Цой появился на телевидении еще до появления группы КИНО.\nА в качестве кого?? ",
                      Answer1 = "служащего ВМС СССР",
                      Answer2 = "талантливого резчика по дереву",
                      Answer3 = "лучшего работника котельной, в которой он работал",
                      Correct = 2
                  });
            Questions.Add(
                   new Question
                   {
                       QuestionNumber = 4,
                       _Question = "С этой песни, можно сказать, началась слава группы КИНО." +
                   "/nВ 1984 году она была признана лучшей песней II фестиваля ленинградского рок-клуба.\nПосле этого музыканты стали регулярно выступать в разных городах Советского Союза.? ",
                       Answer1 = "Бездельник",
                       Answer2 = "Кукушка",
                       Answer3 = "Прохожий",
                       Correct = 3
                   });
            Questions.Add(
                    new Question
                    {
                        QuestionNumber = 5,
                        _Question = "Переименования ГАРИНА И ГИПЕРБОЛОИДОВ в КИНО первый барабанщик группы Олег Валинский \n" +
                " не дождался: его забрали в армию. Служил он на Кубе.\nИнтересна его дальнейшая судьба.Знаете,кто он сегодня ? ",
                        Answer1 = "Посол России на Кубе,конечно",
                        Answer2 = "Крупный чиновник в одной из госкомпаний",
                        Answer3 = "Известный американский художник",
                        Correct = 2
                    });
            Questions.Add(
                    new Question
                    {
                        QuestionNumber = 6,
                        _Question = "Любил ли Цой рисовать? ",
                        Answer1 = "да",
                        Answer2 = "нет",
                        Answer3 = "наверное",
                        Correct = 1
                    }
                    );
        }



        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (user.ChosenAnswer == 0)
            {
                MessageBox.Show("Выберите ответ");
            }
            else
            {
                if (user.ChosenAnswer == Questions[user.QuestionNumber].Correct)
                {
                    user.Score++;
                    updatePage();
                }
                else
                {
                    user.Score--;
                    updatePage();
                }
            }

        }

        private void updatePage()
        {
            PageNumberLb.Content = user.QuestionNumber + 1;
            if (user.QuestionNumber == 6)
            {
                MessageBox.Show(user.HasPassed(user.Score) ? "вы прошли" : "вы не прошли");
                this.Close();
            }
            else
            {
                user.QuestionNumber++;
                QuestionLb.Content = Questions[user.QuestionNumber]._Question;
                AnswerRb1.Content = Questions[user.QuestionNumber].Answer1;
                AnswerRb2.Content = Questions[user.QuestionNumber].Answer2;
                AnswerRb3.Content = Questions[user.QuestionNumber].Answer3;
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow taskWindow = new MainWindow();
            taskWindow.Show();
        }

        private void Answer1_Checked(object sender, RoutedEventArgs e) => user.ChosenAnswer = 1;
        private void Answer2_Checked(object sender, RoutedEventArgs e) => user.ChosenAnswer = 2;
        private void Anserw3_Checked(object sender, RoutedEventArgs e) => user.ChosenAnswer = 3;
    }
}
