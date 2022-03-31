using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Demo.Models
{
    public class PageManager
    {
        [Key]
        public int PageId { get; set; }
        public string PageName { get; set; }
        public string PageDescription { get; set; }
        public int Status { get; set; }
    }
}
