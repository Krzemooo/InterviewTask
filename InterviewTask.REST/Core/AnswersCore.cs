using InterviewTask.Core;
using InterviewTask.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTask.REST.Core
{
    public class AnswersCore
    {
        private WebDBContext _context;

        public AnswersCore(WebDBContext context)
        {
            _context = context;
        }
        public async Task<List<Answers>> GetAnswersAsync()
        {
            return await _context.Answers.ToListAsync();
        }
    }
}
