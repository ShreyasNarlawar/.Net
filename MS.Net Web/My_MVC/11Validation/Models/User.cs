using System.ComponentModel.DataAnnotations;

namespace _11Validation.Models
{
    public class User
    {
        [Required(ErrorMessage ="Name can not be Empty")]
        [StringLength(15,MinimumLength =5,ErrorMessage ="Name should be min 5 and Max 8 charac")]
        public string Name {  get; set; }

        [Required(ErrorMessage ="Email is must")]
        public string Email { get; set; }

        [Required (ErrorMessage ="Age is must")]
        public int? Age{get; set;}

        [Required(ErrorMessage ="Password is must")]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "pwd - min 8 char with one Uppercase,Lowercase, Numbers, Symbals")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Confirm password is must")]
        [Compare("Password", ErrorMessage = "Password does not match!")]
        public string ConfirmPassword {  get; set; }

        [Required(ErrorMessage = "Mobile no is must")]
        [RegularExpression(@"^\+91\s?[6-9]\d{9}$", ErrorMessage = "Incorrect Mobile No")]
        public string MobileNo {  get; set; }

        [Required (ErrorMessage ="URL is must")]
        [Url(ErrorMessage = "Invalid Url")]
        public string WebsiteURL { get; set; }

        [Display(Name="Ask query here:")]
        public string Query {  get; set; }

    }
}
