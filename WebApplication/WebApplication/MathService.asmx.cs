using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication
{
    /// <summary>
    /// Summary description for MathService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MathService : WebService
    {

        [WebMethod]
        public int Add(int a, int b)
        {
            return (a + b);
        }

        [WebMethod]
        public Single Subtract(Single A, Single B)
        {
            return (A - B);
        }

        [WebMethod]
        public Single Multiply(Single A, Single B)
        {
            return A * B;
        }

        [WebMethod]
        public Single Divide(Single A, Single B)
        {
            return B == 0 ? -1 : Convert.ToSingle(A / B);
        }
    }
}