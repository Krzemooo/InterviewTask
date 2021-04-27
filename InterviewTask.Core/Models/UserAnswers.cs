using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InterviewTask.Core.Models
{
    public class UserAnswers
    {
        [Key]
        public int ID { get; set; }
        public Question Question { get; set; }
        public Answers Answers { get; set; }
        public string UserLogin { get; set; }
        public DateTime AnswerDateTime { get; set; }
    }
}
