using Microsoft.EntityFrameworkCore;

namespace ChatGptWizard.Infrastructure.Context
{
    public class ChatGptWizardDbContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(@"Data Source=ChatGptWizard.db");
       
    }
}
