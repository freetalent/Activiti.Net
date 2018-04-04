using System;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Activiti.Net.Test
{
    [TestClass]
    public class ActivitiRESTAPITest
    {
        [TestMethod]
        public void GetTablesTest()
        {
            BasicAuthenticationCredentials credentials = new BasicAuthenticationCredentials
            {
                UserName = "kermit",
                Password = "kermit"
            };

            ActivitiRESTAPI api = new ActivitiRESTAPI(credentials);
            var tables = api.GetTables();
        }
    }
}
