using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net.Http;
using MyBooks;
using System.Collections.Generic;




namespace XML_Project.Pages
{
    public class SearchResultModel : PageModel
    {
        static readonly HttpClient _httpClient = new HttpClient();
        private readonly ILogger<IndexModel> _logger;
        public string Query { get; set; }
        public string Type { get; set; }
        public bool SearchCompleted { get; set; }



       // public SearchResultModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        public SearchResultModel()
        {

        }

        public async void OnGetAsync(string query)
        {
            BooksInfo books = await GetBook(query);
            ViewData["BooksInfo"] = books;
            Query = query;
        }



        public async Task<ApiResponse> GetApiResponseAsync(string query)
        {
            ApiResponse apiResponse = new ApiResponse();
            apiResponse.booksInfo = await GetBook(query);
            return apiResponse;
        }

        private T? GetFromURL<T>(string URL) where T : class
        {

            var task = _httpClient.GetAsync(URL);
            HttpResponseMessage result = task.Result;


            if (result.IsSuccessStatusCode)
            {
                Task<String> readString = result.Content.ReadAsStringAsync();
                string bookJson = readString.Result;



                if (string.IsNullOrEmpty(bookJson))
                {
                    return null;
                }
                T booktitle = JsonConvert.DeserializeObject<T>(bookJson, MyBooks.Converter.Settings); ;
                return booktitle;
            }
            return null;
        }
            public void OnGet(string type, string query)
            {
            SearchCompleted = false;
            Query = query;
                Type = type;
                if (query != null)
                {
                
                    SearchCompleted = true;
                    
                    ViewData["SearchCompleted"] = SearchCompleted;
                }
               
            }





        private async Task<BooksInfo> GetBook(string query)
        {
            var task = _httpClient.GetAsync($"https://www.googleapis.com/books/v1/volumes?q=" + query);

            HttpResponseMessage result = task.Result;
            //List<BooksInfo> books = new List<BooksInfo>();
            BooksInfo books = new BooksInfo();
            if (result.IsSuccessStatusCode)
            {
                SearchCompleted = true;
                Task<string> readString = result.Content.ReadAsStringAsync();
                string jsonString = readString.Result;

                books = BooksInfo.FromJson(jsonString);
            }
            else
            {

            }
            //ViewData["BooksInfo"] = books;
            return books;
        }
    }

}
