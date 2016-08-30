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
        List<string> GetAnserList();







    }


    

    
}










