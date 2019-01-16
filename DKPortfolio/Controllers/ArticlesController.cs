using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DKPortfolio.Data;
using Microsoft.AspNetCore.Mvc;

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
    }
}