﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DKPortfolio.Models
{
    public class Articles
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string MainContent { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
