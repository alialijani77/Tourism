using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Model
{
    public class PageGroup
    {
        public PageGroup() { }
        [Key]
        public int GroupID { get; set; }
        [Display(Name = "استان")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string GroupTitle { get; set; }
        public virtual List<Pages> Pages { get; set; }
    }
}
