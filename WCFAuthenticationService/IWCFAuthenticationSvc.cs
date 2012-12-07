using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFAuthenticationService
{
    [ServiceContract]
    public interface IWCFAuthenticationSvc
    {
        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //User GetDataUsingDataContract(User composite);

        [OperationContract]
        bool Authenticate(string userName, string password);
    }

    [DataContract]
    public class User
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}
