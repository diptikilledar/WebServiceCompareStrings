using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceCompareStrings
{
    /// <summary>
    /// Summary description for CompareWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CompareWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public string compareStrings(string str1, string str2)
        {
            String compareResults = "";
            if (String.Compare(str1, str2) == 0)
                compareResults = $"{str1} equals {str2}.";
            else if (String.Compare(str1, str2) < 0)
                compareResults = $"{str1} before {str2}.";
            else if (String.Compare(str1, str2) > 0)
                compareResults = $"{str1} after {str2}.";

            return compareResults;
        }
    }
}
