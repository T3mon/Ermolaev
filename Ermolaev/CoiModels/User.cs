using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ermolaev
{
    class User
    {
        public User()
        {
            ChosenAnswer = 0;
            Score = 1;
            QuestionNumber = 1;
        }

        public int ChosenAnswer { get; set; }
        public int QuestionNumber { get; set; }
        public int Score { get; set; }
        public bool HasPassed(int Score)
        {
            if (Score > 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
