using ChatGptWizard.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ChatGptWizard.Infrastructure.Interfaces
{
    public interface IMessageRepository
    {
        public Task<Message> GetMessage(int Id);
        public Task<List<Message>> GetMessages();
    }
}
