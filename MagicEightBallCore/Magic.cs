using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicEightBallCore
{
    public static class Magic
    {
        public static string GetAnswer(string userQuestion)
        {
            string question = userQuestion.ToLower();            

            if (question.Contains("name") == true)            
                return "I dont know anything about names";

            if (question.Contains("who") == true)
                return "who... your mama";

            if (question.Contains("what") == true)            
                return "Yes or No questions please.";            

            if (question.Contains("where") == true)            
                return "in your under wear!";
            

            if (question.Contains("when") == true)            
                return "never!";            

            if (question.Contains("gil") == true)
                return "gil is magic";            

            return GetRandomAnswer();
        }

        private static string GetRandomAnswer()
        {
            // Get random number between 0 and 20
            Random rnd = new Random();
            int questionNumber = rnd.Next(0, 20);

            List<string> answerList = new List<string>();
            answerList.Add("It is certain");
            answerList.Add("It is decidedly so");
            answerList.Add("Without a doubt");
            answerList.Add("Yes, definitely");
            answerList.Add("You may rely on it");
            answerList.Add("As I see it, yes");
            answerList.Add("Most likely");
            answerList.Add("Outlook good");
            answerList.Add("Yes");
            answerList.Add("Signs point to yes");
            answerList.Add("Reply hazy try again");
            answerList.Add("Ask again later");
            answerList.Add("Better not tell you now");
            answerList.Add("Cannot predict now");
            answerList.Add("Concentrate and ask again");
            answerList.Add("Don't count on it");
            answerList.Add("My reply is no");
            answerList.Add("Jess says no");
            answerList.Add("Outlook not so good");
            answerList.Add("Very doubtful");
            answerList.Add("You are sleeping, you don not want to believe");

            return answerList[questionNumber];
        }
    }
}
