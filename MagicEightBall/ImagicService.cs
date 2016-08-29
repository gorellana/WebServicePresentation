using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MagicEightBallWcf
{
    // [ServiceContract] Indicates that this interface defines a service contract for a WCF application
    [ServiceContract]
    public interface Imagic
    {
        //[OperationContract]Indicates that this method defines an operation that is part of a service contract
        [OperationContract]
        string SubmitQuestion(string question);

        
        [OperationContract]
        string SubmitQuestionComposite(Request composite);        
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Request
    {
        string firstName = string.Empty;
        string question = string.Empty;

        [DataMember]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        [DataMember]
        public string Question
        {
            get { return question; }
            set { question = value; }
        }
    }

    
}










