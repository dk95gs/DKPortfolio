using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DKPortfolio.Data;
using DKPortfolio.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DKPortfolio.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ArticlesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var articles = _db.Articles.ToList();

            return View(articles);
        }
        public async Task<IActionResult> Details(int Id)
        {
            
            var rec = await _db.Articles.FindAsync(Id);
            ArticleViewModel vm = new ArticleViewModel
            {
                Title = rec.Title,
                PublishDate = rec.PublishDate,
                ImgLink = rec.ImgLink
                //Content = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(rec.MainContent)
            };
            return View(rec);
        }
    }
}