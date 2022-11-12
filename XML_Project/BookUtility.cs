using MyBooks;
using Newtonsoft.Json;
using System.Net.Http;
using XML_Project.Pages;

namespace XML_Project
{
    public static class BookUtility
    {
        static readonly HttpClient client = new HttpClient();
        public static T? GetFromURL<T>(string URL) where T : class
        {
            var task = client.GetAsync(URL);

            HttpResponseMessage response = task.Result;
            if (response.IsSuccessStatusCode)
            {
                Task<string> bookTask = response.Content.ReadAsStringAsync();
                string bookInformarion = bookTask.Result;
                if (string.IsNullOrEmpty(bookInformarion))
                {
                    return null;
                }

                // T books = BooksInfo.FromJson(jsonString);
                T books = JsonConvert.DeserializeObject<T>(bookInformarion, MyBooksBestSellers.Converter.Settings);
                return books;
            }
            return null;
        }
    }
}
