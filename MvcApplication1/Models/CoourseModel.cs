using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class CourseModel
    {
        public int ID { get; set; }
        public string Name { set; get; }
        public string Theme { set; get; }
        public string level { set; get; }
        public string ImageSource { set; get; }
        public string Description { set; get; }
        public double Price { set; get; }
        public string autor { set; get; }
        public int autorID { set; get; }
        public int rating { set; get; }

    }
    
}