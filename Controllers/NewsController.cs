using Assignment__1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Security.Cryptography.Xml;
using Newtonsoft.Json;

namespace Assignment__1.Controllers
{
    public class NewsController : Controller
    {
            public async Task<IActionResult> Index()
            {
                var news=await GetNews();
                return View(news);
            }
            public async Task<IEnumerable<NewsArticle>> GetNews()
            {
                List<NewsArticle> news = new List<NewsArticle>();
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("https://newsapi.org/v2/top-headlines?country=us&category=business&apiKey=5a7a3f934a99402c892fa400afa2acbf").ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var _newsList = JsonConvert.DeserializeObject<NewsList>(jsonString);

                    if (_newsList != null)
                    {
                        news.AddRange(_newsList.NewsArticles);
                    }
                }

                foreach(var item in news)
                {
                    Console.WriteLine(item.Author);
                    Console.WriteLine(item.Title);
                }

                return news;
            }
    }
}