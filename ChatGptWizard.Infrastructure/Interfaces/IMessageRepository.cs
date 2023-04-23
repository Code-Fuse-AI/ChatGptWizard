using ChatGptWizard.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ChatGptWizard.Infrastructure.Interfaces
{
    public interface IMessageRepository
    {
        public Message GetMessage(int id);
        public DbSet<Message> GetMessages();
    }
}
