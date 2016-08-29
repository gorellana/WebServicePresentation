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
       
        [Route("api/answers")]      
        [HttpGet]
        public string GetAnswer(string question)
        {
            if (question.Contains("name") == true)
            {
                return "I dont know anything about names";
            }

            MagicEightBallService wcf = new MagicEightBallService();
            return wcf.SubmitQuestion(question);            
        }


        [Route("api/answers")]
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
