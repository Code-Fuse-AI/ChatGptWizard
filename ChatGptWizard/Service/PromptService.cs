using System;
using ChatGptWizard.Data;
using ChatGptWizard.Service.IService;

namespace ChatGptWizard.Service
{
    public class PromptService : IPromptService
    {
        // Add constructor and inject AppDbContext, etc.

        public async Task<IEnumerable<Prompt>> GetPromptsAsync()
        {
            // Create a list of dummy prompts
            var dummyPrompts = new List<Prompt>
            {
                new Prompt { Id = 1, Text = "Dummy prompt 1", CreatedAt = DateTime.Now, IsExternal = false },
                new Prompt { Id = 2, Text = "Dummy prompt 2", CreatedAt = DateTime.Now, IsExternal = false },
                new Prompt { Id = 3, Text = "Dummy prompt 3", CreatedAt = DateTime.Now, IsExternal = true },
            };

            // Return the dummy data as an asynchronous task result
            return await Task.FromResult(dummyPrompts);
        }

        public async Task<Prompt> GetPromptByIdAsync(int id)
        {
                var dummyPrompt = new Prompt
                {
                    Id = id,
                    Text = $"Dummy prompt {id}",
                    CreatedAt = DateTime.Now,
                    IsExternal = false
                };

                // Return the dummy data as an asynchronous task result
                return await Task.FromResult(dummyPrompt);
            }

        public Task AddPromptAsync(Prompt prompt)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePromptAsync(Prompt prompt)
        {
            throw new NotImplementedException();
        }

        public Task DeletePromptAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

