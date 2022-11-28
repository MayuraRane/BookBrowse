using MyBooks;
using System.Net.Http;

namespace XML_Project
{
    public class APILink
    {
        static readonly HttpClient _httpClient = new HttpClient();
        public async Task<ApiResponse> GetApiResponseAsync(string query)
        {
            ApiResponse apiResponse = new ApiResponse();
            apiResponse.booksInfo = await GetBook(query);
            return apiResponse;
        }

        private async Task<BooksInfo> GetBook(string? query)
        {
            var task = _httpClient.GetAsync($"https://www.googleapis.com/books/v1/volumes?q=" + query);

            HttpResponseMessage result = task.Result;
            
            BooksInfo books = new BooksInfo();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readString = result.Content.ReadAsStringAsync();
                string jsonString = readString.Result;

                books = BooksInfo.FromJson(jsonString);
            }
            else
            {

            }
           
            return books;
        }
    }
}
