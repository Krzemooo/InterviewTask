using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InterviewTask.Core.Models
{
    public class Question
    {
        [Key]
        public int ID { get; set; }
        public string QuestionContent { get; set; }
    }
}
