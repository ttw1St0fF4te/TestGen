using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerator
{
    public class Test
    {
        public string QuestionName { get; set; }
        public string QuestionInfo { get; set; }
        public string FirstAnswer { get; set; }
        public string SecondAnswer { get; set; }
        public string ThirdAnswer { get; set; }
        public enum RightAnswerr
        {
            FirstAnswer,
            SecondAnswer,
            ThirdAnswer
        }
        public RightAnswerr RightAnswer { get; set; }

        public Test(string questionName, string questionInfo, string firstAnswer, string secondAnswer, string thirdAnswer, RightAnswerr rightAnswer)
        {
            QuestionName = questionName;
            QuestionInfo = questionInfo;
            FirstAnswer = firstAnswer;
            SecondAnswer = secondAnswer;
            ThirdAnswer = thirdAnswer;
            RightAnswer = rightAnswer;
        }
    }
}
