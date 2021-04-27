using InterviewTask.Core;
using InterviewTask.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTask.REST.Controllers
{
    [ApiController]
    [Route("rest")]
    public class RESTController : ControllerBase
    {
        private readonly ILogger<RESTController> _logger;
        private readonly WebDBContext _context;

        public RESTController(ILogger<RESTController> logger, WebDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        [Route("GetQuestions")]
        public async Task<List<Question>> GetQuestionAsync()
        {
            Core.QuestionCore questionCore = new Core.QuestionCore(_context);
            return await questionCore.GetQuestionsAsync();
        }

        [HttpGet]
        [Route("GetAnswers")]
        public async Task<List<Answers>> GetAnswersAsync()
        {
            Core.AnswersCore answersCore = new Core.AnswersCore(_context);
            return await answersCore.GetAnswersAsync();
        }

        [HttpPost]
        [Route("InsertUserAnswer")]
        public async Task InsertUserAnswerAsync(List<UserAnswers> userAnswers)
        {
            Core.UserAnswersCore userAnswersCore = new Core.UserAnswersCore(_context);
            await userAnswersCore.InsertUserAnswersAsync(userAnswers);

        }
    }
}
