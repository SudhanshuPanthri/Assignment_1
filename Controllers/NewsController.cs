using Assignment__1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace Assignment__1.Controllers
{
    [Authorize]
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
                HttpResponseMessage response = await client.GetAsync("https://newsapi.org/v2/top-headlines?country=us&category=business&apiKey=64df9ca2459f42be8b83c9927ea64454").ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var _newsList = JsonConvert.DeserializeObject<NewsList>(jsonString);

                    if (_newsList != null)
                    {
                        news.AddRange(_newsList.NewsArticles);
                    }
                }
                return news;
            }
    }
}