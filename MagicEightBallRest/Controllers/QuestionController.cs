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
    
    public class AnswerController : ApiController
    {
        // Gets All the answers //http://localhost/mebRest/api/answer
        [Route("api/answer")]
        [HttpGet]
        public MagicResponse GetAnswer()
        {
            if (!String.IsNullOrEmpty(Request.RequestUri.Query.ToString()))
            {               
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            MagicResponse response = new MagicResponse();
            response.AllAnswers = Magic.GetAnswerList();
            return response;
        }

        //return an answer by question number http://localhost/mebRest/api/answer/1
        [Route("api/answer/{questionNumber}")]
        [HttpGet]
        public MagicResponse GetAnswer(int questionNumber)
        {
            MagicResponse response = new MagicResponse();

            List<string> answers = Magic.GetAnswerList();
               
            if (questionNumber >= 0 && questionNumber <= answers.Count)
            {
                 response.MagicAnswer = string.Format("Question {0} is: {1}", questionNumber, answers[questionNumber - 1]);
                return response;
            }

            response.MagicAnswer = string.Format("Queseton {0} does not exist",questionNumber);
            return response;                      
        }

        // Question in query string http://localhost/mebRest/api/answer?question=did I go
        [Route("api/answer/")]
        [HttpGet]
        public MagicResponse AskQuestion(string question)
        {
            MagicResponse response = new MagicResponse();

            int number;
            bool isNumber = int.TryParse(question, out number);
            if (!int.TryParse(question, out number) )
            {
                response.MagicAnswer =  Magic.GetAnswer(question);
                return response;
            }

            response.MagicAnswer = string.Format("{0} What?... that is not a question.",question);
            return response;                               
        }                                
    }
}
