using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChatGptWizard.Service
{
    public class OpenAIApiService
    {
        private readonly HttpClient _httpClient;

        public OpenAIApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> SendMessageAsync(string apiKey, string prompt, string responseType)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

            var requestBody = new
            {
                prompt = prompt,
                max_tokens = 150,
                temperature = 0.5,
                n = 1,
                stop = "\n",
                model = "text-davinci-002",
            };

            var content = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://api.openai.com/v1/engines/davinci-codex/completions", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"API request failed with status code: {response.StatusCode}");
            }

            var jsonResponse = await response.Content.ReadAsStringAsync();

            var result = JsonDocument.Parse(jsonResponse).RootElement.GetProperty("choices")[0].GetProperty(responseType).GetString();

            return result;
        }
    }
}



