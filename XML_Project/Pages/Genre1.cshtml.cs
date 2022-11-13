using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBooks;
using Newtonsoft.Json;

namespace XML_Project.Pages
{
    public class Genre1Model : PageModel
    {
        static readonly HttpClient client = new HttpClient();

        private readonly ILogger<IndexModel> _logger;

        public Genre1Model(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            var task = client.GetAsync($"https://www.googleapis.com/books/v1/volumes?q=subject:thriller");

            HttpResponseMessage result = task.Result;
            BooksInfo books = new BooksInfo();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readString = result.Content.ReadAsStringAsync();
                string jsonString = readString.Result;

                books = BooksInfo.FromJson(jsonString);
            }
            ViewData["BooksInfo"] = books;

        }
    }
}