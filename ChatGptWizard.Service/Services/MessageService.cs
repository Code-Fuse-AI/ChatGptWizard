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
        public Message GetMessage(int id)
        {
            return _messageRepository.GetMessage(id);
        }

        public DbSet<Message> GetMessages()
        {
            return _messageRepository.GetMessages();
        }
    }
}
