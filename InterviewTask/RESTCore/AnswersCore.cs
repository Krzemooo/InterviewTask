using InterviewTask.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTask.RESTCore
{
    public partial class RESTCore
    {
        public async Task<List<Answers>> GetAnswers()
        {
            var response = await _Client.GetAsync("rest/GetAnswers");
            return JsonConvert.DeserializeObject<List<Answers>>(await response.Content.ReadAsStringAsync());
        }
    }
}
