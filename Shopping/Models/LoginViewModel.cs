using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [EmailAddress(ErrorMessage = "Dedes ingresar un correo valido.")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MinLength(6, ErrorMessage = "El campo {0} deb tener al menos {1} caracteres.")]
        public string Password { get; set; }

        [Display(Name = "Recordarme en este navegador")]
        public bool RememberMe { get; set; }
    }
}
