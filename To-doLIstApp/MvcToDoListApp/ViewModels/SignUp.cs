using System.ComponentModel.DataAnnotations;

namespace MvcToDoListApp.ViewModels
{
    public class SignUp
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
