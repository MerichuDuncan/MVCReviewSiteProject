using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCReviewSiteProj.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Type { get; set; }

        //Added cause this list would have many tasks
        public virtual ICollection<Review> Reviews { get; set; }

    }
}