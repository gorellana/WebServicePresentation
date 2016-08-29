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

        public  string SubmitQuestionComposite(Request question)
        {
            string answer = "This is the ansswer";

            

            return answer;
        }


        
        
    }
}
