using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace baiTapTuan2.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Họ và tên của bạn: ")]
        public string StudentName { get; set; }
        [Display(Name = "Giới tính: ")]
        public bool StudentGender { get; set; }
        [Display(Name = "Tuổi: ")]
        public int Age { get; set; }
        [Display(Name = "Địa chỉ: ")]
        public String Address { get; set; }
        [Display(Name = "Quê quán: ")]
        public tinhThanh cacTinh { get; set; }
    }
    public enum tinhThanh
    {
        Hồ_Chí_Minh,
        Hà_Nội,
        Hải_Phòng,
        Cần_Thơ
    }
}