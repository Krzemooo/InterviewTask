using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InterviewTask.Core.Models
{
    public class Answers
    {
        [Key]
        public int ID { get; set; }
        public string AnswerContent { get; set; }
        public Question Question { get; set; }
    }
}
