using InterviewTask.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTask.Models
{
    public class HomepageModel
    {
        public List<Question> Questions { get; set; }
        public List<Answers> Answers { get; set; }
    }
}
