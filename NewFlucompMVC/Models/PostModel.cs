using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewFlucompMVC.Models
{
    public class PostModel
    {
        public string Title { get; set; }
        public DateTime DatePosted { get; set; }
        public string Author { get; set; }
        public string Contents { get; set; }
    }
}