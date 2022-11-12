using System.Collections;
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
            BooksInfo books = BookUtility.GetFromURL<BooksInfo>("https://www.googleapis.com/books/v1/volumes?q=subject:thriller");
            ViewData["BooksInfo"] = books;

        }
    }
}