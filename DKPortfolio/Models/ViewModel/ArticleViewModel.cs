using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DKPortfolio.Models.ViewModel
{
    public class ArticleViewModel
    {
        public string Title { get; set; }
        public string ImgLink { get; set; }
    
        public DateTime PublishDate { get; set; }
        public Dictionary<string,List<string>> Content { get; set; }
        
    }
}
