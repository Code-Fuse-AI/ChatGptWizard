using ChatGptWizard.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ChatGptWizard.Core.Interfaces
{
    public interface IMessageService
    {
        public Task<Message> GetMessage(int Id);
        public Task<List<Message>> GetMessages();
    }
}
