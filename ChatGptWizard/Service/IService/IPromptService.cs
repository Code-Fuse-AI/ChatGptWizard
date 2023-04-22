using System;
using ChatGptWizard.Data;

namespace ChatGptWizard.Service.IService
{
    public interface IPromptService
    {
        Task<IEnumerable<Prompt>> GetPromptsAsync();
        Task<Prompt> GetPromptByIdAsync(int id);
        Task AddPromptAsync(Prompt prompt);
        Task UpdatePromptAsync(Prompt prompt);
        Task DeletePromptAsync(int id);
    }
}

