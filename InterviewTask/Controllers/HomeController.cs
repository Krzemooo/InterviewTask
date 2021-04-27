using InterviewTask.Core;
using InterviewTask.Core.Models;
using InterviewTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            HomepageModel model = new HomepageModel();
            RESTCore.RESTCore rest = new RESTCore.RESTCore();
            model.Questions = await rest.GetQuestions();
            model.Answers = await rest.GetAnswers();
            return View(model);
        }

        public async Task<IActionResult> SaveUserAnswer(string userLogin, List<int> checkedAnswers)
        {
            RESTCore.RESTCore rest = new RESTCore.RESTCore();
            List<UserAnswers> userAnswers = new List<UserAnswers>();

            foreach (int answerID in checkedAnswers)
            {
                userAnswers.Add(new UserAnswers()
                {
                    AnswerDateTime = DateTime.UtcNow,
                    Answers = new Answers() { ID = answerID },
                    UserLogin = userLogin
                });
            }

            await rest.SaveUserAnsewer(userAnswers);
            return Ok();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
