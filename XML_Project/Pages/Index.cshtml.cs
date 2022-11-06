using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBooksBestSellers;
using Newtonsoft.Json;

namespace XML_Project.Pages
{
    public class IndexModel : PageModel
    {
        static readonly HttpClient client = new HttpClient();

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
            var task = client.GetAsync($"https://api.nytimes.com/svc/books/v3/lists/current/combined-print-and-e-book-fiction.json?api-key=9HUdSuV0N5BHY93RrWkP48aDrVztk4PL");
            
            HttpResponseMessage result =  task.Result;
            //List<BooksInfo> books = new List<BooksInfo>();
            BestSellers bs_books = new BestSellers();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readString = result.Content.ReadAsStringAsync();
                string jsonString = readString.Result;
             
                bs_books = BestSellers.FromJson(jsonString);
            }
            ViewData["BestSellers"] = bs_books;

        }
    }
}