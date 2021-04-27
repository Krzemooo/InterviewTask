using InterviewTask.Core;
using InterviewTask.REST.Controllers;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace InterviewTask.Test
{
    public class UnitTest
    {
        private WebDBContext _context;

        [Fact]
        public async void GetQuestions_Test()
        {
            var options = new DbContextOptionsBuilder<WebDBContext>()
                   .UseSqlServer(new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=InterviewTaskDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                   .Options;
            _context = new WebDBContext(options);
            var controller = new RESTController(null, _context);

            controller.ModelState.AddModelError("Slug", "Required");

            var result = await controller.GetQuestionAsync();

            Assert.NotEmpty(result);
        }
    }
}
