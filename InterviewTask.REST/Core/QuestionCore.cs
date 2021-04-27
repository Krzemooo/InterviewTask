using InterviewTask.Core;
using InterviewTask.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTask.REST.Core
{
    public class QuestionCore
    {
        private WebDBContext _context;

        public QuestionCore(WebDBContext context)
        {
            _context = context;
        }
        public async Task<List<Question>> GetQuestionsAsync()
        {
            return await _context.Questions.ToListAsync();
        }
    }
}
