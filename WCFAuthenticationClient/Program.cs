using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WCFAuthenticationClient.WCFAuthenticationSvcReference;

namespace WCFAuthenticationClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WCFAuthenticationSvcReference.WCFAuthenticationSvcClient proxy = new WCFAuthenticationSvcClient();
            bool result = proxy.Authenticate("Regis", "Regis");
            Console.Out.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
