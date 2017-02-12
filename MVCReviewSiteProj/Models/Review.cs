using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSiteProj.Models
{
    public class Review
    {
        [Key]
        //fields and properties
        public int ID { get; set; }

        //Product hierarchy
        [Display(Name ="Brand")]
        public string BrandName { get; set; }
        [Display(Name ="Model")]
        public string ModelName { get; set; }
        [Display(Name ="Publish Date")]
        public DateTime PublishDate { get; set; }

        [Display(Name ="Name")]
        public string UserName { get; set; }
        [Display(Name ="Email Address")]
        public string EmailAdd { get; set; }
        [Display(Name ="Write your Review")]
        public string Content { get; set; }
        [Display(Name ="Over All Rating")]
        public int overAllRate { get; set; }
        [Display(Name ="Is this HelpFul?")]
        public bool Helpful { get; set; }


        //Asigning foreign key indorder to link classes in Models
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }



    }
}