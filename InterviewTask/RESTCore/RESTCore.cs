using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace InterviewTask.RESTCore
{
    public partial class RESTCore
    {
        private HttpClient _Client;

        public RESTCore()
        {
            HttpClientHandler httpClient = new HttpClientHandler();
            _Client = new HttpClient(httpClient)
            {
                BaseAddress = new Uri("http://localhost:58513/")
            };
        }
    }
}
