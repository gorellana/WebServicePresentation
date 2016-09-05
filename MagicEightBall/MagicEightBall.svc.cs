using MagicEightBallCore;
using System.Collections.Generic;

namespace MagicEightBallWcf
{
    public class MagicEightBallService : Imagic
    {
        public MagicResponse SubmitQuestion(string question)
        {
            MagicResponse answer = new MagicResponse();

            if (string.IsNullOrEmpty(question))
            {
                answer.MagicAnswer = "What is your question?";
                return answer;
            }

            
            answer.MagicAnswer = MagicEightBallCore.Magic.GetAnswer(question);
            return answer;
        }

        public MagicResponse GetAnwserList()
        {
            MagicResponse answer = new MagicResponse();
            answer.AllAnswers =  Magic.GetAnswerList();
            return answer;
        }

        public MagicResponse GetAnswerByQuestionNumber(int questionNumber)
        {
            MagicResponse answer = new MagicResponse();

            List<string> answers = Magic.GetAnswerList();

            if (questionNumber >= 0 && questionNumber <= answers.Count)
            {
                answer.MagicAnswer =  string.Format("Question {0} is: {1}", questionNumber, answers[questionNumber - 1]);
                return answer;
            }

            answer.MagicAnswer =  string.Format("Queseton {0} does not exist", questionNumber);
            return answer;
        }
    }
}
