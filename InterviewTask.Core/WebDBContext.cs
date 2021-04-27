using InterviewTask.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.Core
{
    public class WebDBContext : DbContext
    {
        public WebDBContext(DbContextOptions<WebDBContext> options) : base(options)
        {

        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<UserAnswers> UserAnswers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
        }
    }
}
