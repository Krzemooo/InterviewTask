using InterviewTask.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask.RESTCore
{
    public partial class RESTCore
    {
        public async Task SaveUserAnsewer(List<UserAnswers> userAnswers)
        {
            string requestContent = JsonConvert.SerializeObject(userAnswers);
            await _Client.PostAsync("rest/InsertUserAnswer", new StringContent(requestContent, Encoding.UTF8, "application/json"));
        }
    }
}
