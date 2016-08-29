using MagicEightBallCore;
using MagicEightBallWcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MagicEightBallRest.Controllers
{
    //http://localhost/magicEightBallRest/api/answers?question=how%20do%20you%20do%20it
    public class AnswerController : ApiController
    {
        // Gets All the answers
        [Route("api/answer")]
        [HttpGet]
        public List<string> GetAnswer()
        {
           return Magic.GetAnswerList();
        }

        //Gets the answer that correstponds to the number the user typed in
        [Route("api/answer/{questionNumber}")]
        [HttpGet]
        public string GetAnswer(int questionNumber)
        {
           
            List<string> answers = Magic.GetAnswerList();
               
            if (questionNumber >= 0 && questionNumber <= answers.Count)
            {
                 return string.Format("Question {0} is: {1}", questionNumber, answers[questionNumber - 1]);
            }           
                       
             return string.Format("Queseton {0} does not exist",questionNumber);                       
        }

        // answer based on query string ?question=is my name
        [Route("api/answer")]      
        [HttpGet]
        public string AskQuestion(string question)
        {
            int number;
            bool isNumber = int.TryParse(question, out number);
            if (!int.TryParse(question, out number) )
            {
                return Magic.GetAnswer(question);
            }

            return string.Format("{0} What?... that is not a question.",question);
                               
        }

        [Route("api/answer")]
        [HttpGet]
        public string GetAnswer(string question, string name)
        {
            MagicEightBallService wcf = new MagicEightBallService();
            return wcf.SubmitQuestion(question);
        }

        [Route("api/orders/{id}")]
        [HttpGet]
        public string GetOrders(int id)
        {
            return string.Format("Your Order {0} contains french fries",id);
        }
    }
}
