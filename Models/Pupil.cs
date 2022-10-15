using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace baiTapTuan2.Models
{
    public class Pupil
    {
        public int Id { get; set; }
        [Display(Name = "Name: ")]
        public string Name { get; set; }
        [Display(Name = "Age: ")]
        public int Age { get; set; }
        public Sex GioiTinh { get; set; }
        [Display(Name = "IsNewLyAccount: ")]
        public bool IsNewlyAccount { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string Password { get; set; }
        [Display(Name = "DoB: ")]
        public DateTime dateTime { get; set; }
    }
    public enum Sex
    {
        nam,
        nu
    }
}