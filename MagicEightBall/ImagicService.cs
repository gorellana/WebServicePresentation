using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace MagicEightBallWcf
{
    // [ServiceContract] Indicates that this interface defines a service contract for a WCF application
    [ServiceContract]
    public interface Imagic
    {
        //[OperationContract]Indicates that this method defines an operation that is part of a service contract
        [OperationContract]
        MagicResponse SubmitQuestion(string question);

        [OperationContract]
        MagicResponse GetAnwserList();

        [OperationContract]
        MagicResponse GetAnswerByQuestionNumber(int questionNumber);

    }    

    [DataContract]
    public class MagicResponse
    {
        [DataMember]
        public string MagicAnswer { get; set; }

        [DataMember]
        public List<string> AllAnswers { get; set; }
    }

}










