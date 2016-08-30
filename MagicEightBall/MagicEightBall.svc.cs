using MagicEightBallCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MagicEightBallWcf
{

    public class MagicEightBallService : Imagic
    {
        public  string SubmitQuestion(string question)
        {
            if (string.IsNullOrEmpty(question))
            {
                return "What is your question?";
            }
            return MagicEightBallCore.Magic.GetAnswer(question);
        }

        public List<string> GetAnserList()
        {
            return Magic.GetAnswerList();
        }


        public string GetAnswerByQuestionNumber(int questionNumber)
        {

            List<string> answers = Magic.GetAnswerList();

            if (questionNumber >= 0 && questionNumber <= answers.Count)
            {
                return string.Format("Question {0} is: {1}", questionNumber, answers[questionNumber - 1]);
            }

            return string.Format("Queseton {0} does not exist", questionNumber);
        }



    }
}
