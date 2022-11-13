using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XML_Project.Pages
{
    public class SearchResultModel : PageModel
    {
        static readonly HttpClient client = new HttpClient();

        private readonly ILogger<SearchResultModel> _logger;

    }
}
