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
        public async Task<List<Question>> GetQuestions()
        {
            var response = await _Client.GetAsync("rest/GetQuestions");
            return JsonConvert.DeserializeObject<List<Question>>(await response.Content.ReadAsStringAsync());
        }
    }
}
