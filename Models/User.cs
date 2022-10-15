using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace baiTapTuan2.Models
{
    public class User
    {
        [Display(Name = "Account")]
        public String Account { get; set; }
        [Display(Name = "Password")]
        public String Password { get; set; }
        [Display(Name = "Name ")]
        public String UserName { get; set; }
        [Display(Name = "Age")]
        public int age { get; set; }
        [Display(Name = "IsNewlyAccount")]
        public bool IsNewlyAcccount { get; set; }
        [Display(Name = "IsActivated")]
        public bool IsActivated { get; set; }
        [Display(Name = "IsActivated")]
        public bool IsDeleted { get; set; }

    }
}
