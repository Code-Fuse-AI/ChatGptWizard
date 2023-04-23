using ChatGptWizard.Core.Interfaces;
using ChatGptWizard.Infrastructure.Context;
using ChatGptWizard.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ChatGptWizard.Core.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;
        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public async Task<Message> GetMessage(int id)
        {
            return await _messageRepository.GetMessage(id);
        }

        public async Task<List<Message>> GetMessages()
        {
            return await _messageRepository.GetMessages();
        }
    }
}
