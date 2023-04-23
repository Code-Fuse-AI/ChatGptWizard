using ChatGptWizard.Infrastructure.Context;
using ChatGptWizard.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ChatGptWizard.Infrastructure.Repository
{
    public class MessageRepository : IMessageRepository
    {
        protected readonly ChatGptWizardDbContext _context;
        public MessageRepository(ChatGptWizardDbContext context)
        {
            _context = context;
        }
        public async Task<Message> GetMessage(int Id)
        {
            Message result = null;
            try
            {
                result = await _context.Messages.SingleOrDefaultAsync(x => x.Id == Id);
            }
            catch (Exception ex)
            {
                var error = ex.Message.ToString();
            }
            return result;
        }

        public async Task<List<Message>> GetMessages()
        {
            List<Message> result = null;
            try
            {
                result = await _context.Messages.ToListAsync();
            }
            catch (Exception ex)
            {
                var error = ex.Message.ToString();
            }
            return result;
        }
    }
}
