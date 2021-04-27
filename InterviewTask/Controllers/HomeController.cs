using InterviewTask.Core;
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

        public async Task<IActionResult> SaveUserAnswer(string UserLogin, List<int> checkedAnswers)
        {

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
