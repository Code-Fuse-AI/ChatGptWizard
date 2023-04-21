using System;
namespace ChatGptWizard.Service.IService
{
    public interface IExternalLibraryService
    {
        Task DownloadPromptsAsync();
    }
}

