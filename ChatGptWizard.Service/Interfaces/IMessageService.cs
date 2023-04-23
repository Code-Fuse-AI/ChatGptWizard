using ChatGptWizard.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ChatGptWizard.Core.Interfaces
{
    public interface IMessageService
    {
        public Message GetMessage(int id);
        public DbSet<Message> GetMessages();
    }
}
