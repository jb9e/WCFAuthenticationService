using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFAuthenticationService
{
    public class WCFAuthenticationSvc : IWCFAuthenticationSvc
    {
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public User GetDataUsingDataContract(User composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}

        public bool Authenticate(string userName, string password)
        {
            if (userName.ToUpper() == "REGIS" && password.ToUpper() == "REGIS")
            {
                return true;
            }

            return false;

            //DataExchangeMVCEntities context = new DataExchangeMVCEntities();
            //var userEntity = (from u
            //                     in context.UserEntities
            //                     where u.Name == userName && u.Password == password
            //                     select u).FirstOrDefault();

            //if (userEntity != null)
            //{
            //    return true;
            //}

            //return false;
        }
    }
}
