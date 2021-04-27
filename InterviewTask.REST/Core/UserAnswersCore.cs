using InterviewTask.Core;
using InterviewTask.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTask.REST.Core
{
    public class UserAnswersCore
    {
        private WebDBContext _context;

        public UserAnswersCore(WebDBContext context)
        {
            _context = context;
        }
        public async Task InsertUserAnswersAsync(List<UserAnswers> userAnswers)
        {
            if (userAnswers != null && userAnswers.Count > 0)
            {
                foreach (var singleAnswer in userAnswers)
                {
                    var answerItem = _context.Answers.First(s => s.ID == singleAnswer.Answers.ID);
                    if (answerItem != null)
                    {
                        singleAnswer.Answers = answerItem;
                        _context.UserAnswers.Add(singleAnswer);
                    }
                }
                await _context.SaveChangesAsync();
            }
        }
    }
}
