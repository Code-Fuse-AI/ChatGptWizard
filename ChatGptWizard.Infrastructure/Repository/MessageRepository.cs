using ChatGptWizard.Infrastructure.Context;
using ChatGptWizard.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ChatGptWizard.Infrastructure.Repository
{
    public class MessageRepository : IMessageRepository
    {
        protected readonly ChatGptWizardDbContext _context;
        public MessageRepository(ChatGptWizardDbContext context)
        {
            _context = context;
        }
        public Message GetMessage(int Id)
        {
            return _context.Messages.Single(x => x.Id == Id);
        }

        public DbSet<Message> GetMessages()
        {
            return _context.Messages;
        }
    }
}
