using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Net.Http;
using BookBrowse.Pages;

namespace BookBrowse.Pages
{
    public class MovieModel : PageModel
    {
        static readonly HttpClient _httpClient = new HttpClient();
        public bool DisplaySearch { get; set; }

        private T? GetFromURL<T>(string URL) where T : class
        {
            var task = _httpClient.GetAsync(URL);
            HttpResponseMessage result = task.Result;
            //List<T> meals = new List<T>();

            if (result.IsSuccessStatusCode)
            {
                Task<String> readString = result.Content.ReadAsStringAsync();
                string BookJson = readString.Result;

                if (string.IsNullOrEmpty(BookJson))
                {
                    return null;
                }
                T movie = JsonConvert.DeserializeObject<T>(BookJson, BookBrowse.Converter.Settings); ;
                return movie;
            }
            return null;
        }

        public void OnGet()
        {
            DisplaySearch = getMovie();
            ViewData["DisplaySearch"] = DisplaySearch;
        }

        private bool getMovie()
        {
            DisplaySearch = false;
            Movie movie = GetFromURL<Movie>("https://watchnowapi.azurewebsites.net/TrendingMovies");
            List<MovieResult> movies = new List<MovieResult>();

            if (movie != null)
            {

                movies = movie.Results;

                DisplaySearch = true;
            }



            ViewData["Movies"] = movies;
            return DisplaySearch;

        }
    }
}
