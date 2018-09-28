using System.ComponentModel.DataAnnotations;

namespace ConssmWeb.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage ="Numele este obligatoriu")]
        [Display(Name = "Nume")]
        public string Name { get; set; }
        [Required(ErrorMessage = "E-mail-ul este obligatoriu")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mesajul este obligatoriu")]
        [Display(Name = "Mesaj")]
        public string Message { get; set; }
        [Display(Name = "E-mail confirmare")]
        public bool ConfirmationEmail { get; set; }
        [Required(ErrorMessage = "Captcha-ul este obligatoriu")]
        [Display(Name = "Captcha")]
        public string CaptchaCode { get; set; }
    }
}
