using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBooks;
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
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            string Bookkey = "9HUdSuV0N5BHY93RrWkP48aDrVztk4PL";
           
            var task = client.GetAsync($"https://api.nytimes.com/svc/books/v3/lists/current/combined-print-and-e-book-fiction.json?api-key=" + Bookkey);

            HttpResponseMessage result =  task.Result;
            //List<BooksInfo> books = new List<BooksInfo>();
            BestSellers bs_books = new BestSellers();
            if (result.IsSuccessStatusCode)
            try
            {
                ViewData["ErrorMessage"] = null;
                BestSellers books = BookUtility.GetFromURL<BestSellers>("https://api.nytimes.com/svc/books/v3/lists/current/combined-print-and-e-book-fiction.json?api-key=9HUdSuV0N5BHY93RrWkP48aDrVztk4PL");
                // Create empty if none found and set Error message to be displayed on screen
                if (books == null)
                {
                    books = new BestSellers();
                    ViewData["ErrorMessage"] = "No Book Information was found";
                }
                ViewData["BestSellers"] = books;
            }
            catch(Exception ex)
            {
                ViewData["ErrorMessage"] = "Error retrieving Book information - Please try again later";
            }
        }
    }
}