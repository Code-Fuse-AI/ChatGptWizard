using Microsoft.EntityFrameworkCore;

namespace ChatGptWizard.Infrastructure.Context
{
    public class ChatGptWizardDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source=ChatGptWizard.db");
        }
        public DbSet<Message> Messages { get; set; }
    }
}
