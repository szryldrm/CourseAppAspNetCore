using System;
using System.ComponentModel.DataAnnotations;

namespace CourseApp.Web.Models
{
    public class Student
    {
        [Required(ErrorMessage = "İsminizi Giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mail Adresinizi Giriniz.")]
        [EmailAddress(ErrorMessage = "Lütfen Mail Adresinizi Düzgün Giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon Numaranızı Giriniz.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Kursa Katılıp Katılmayacağınızı Belirtiniz.")]
        public bool? WillAttend { get; set; }
    }
}
