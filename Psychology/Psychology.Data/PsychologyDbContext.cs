using Microsoft.EntityFrameworkCore;
using Psychology.Core.Models;
using Psychology.Data.Configurations;

namespace Psychology.Data
{
    public class PsychologyDbContext : DbContext
    {
        public PsychologyDbContext(DbContextOptions<PsychologyDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AdminConfiguration());
            builder.ApplyConfiguration(new QuestionConfiguration());
            builder.ApplyConfiguration(new AnswerConfiguration());
            builder.ApplyConfiguration(new TestingConfiguration());
            builder.ApplyConfiguration(new TestingAnswerConfiguration());
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Testing> Testings { get; set; }
        public DbSet<TestingAnswer> testingAnswers { get; set; }
    }
}
