using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Model
{
    public class Pages
    {
        public Pages() { }
        [Key]
        public int PageID { get; set; }
        [Display(Name = "استان")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public int GroupID { get; set; }
        [Display(Name = "متن اصلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string PageText { get; set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(500)]
        public string PageDescription { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(200)]
        public string Title { get; set; }
        [Display(Name = "کلمات کلیدی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(300)]
        public string Tags { get; set; }
        [Display(Name = "بازدید")]
        public int Visit { get; set; }
        [Display(Name = "عکس")]
        public string ImageName { get; set; }
        [Display(Name = "تاریخ انتشار")]
        public DateTime CreateTime { get; set; }
        [Display(Name = "اسلایدر")]
        public bool ShowSlider { get; set; }
        public virtual PageGroup PageGroup { get; set; }
    }
}
