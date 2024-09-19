using System.ComponentModel.DataAnnotations;

namespace AdminProyectosBlazorWasm.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Rol es obligatorio")]
        public int IdRol { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El Login es obligatorio")]
        public string Login { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [StringLength(32, ErrorMessage = "Password debe estar entre 5 a 32 caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Clave { get; set; }

        [Required(ErrorMessage = "La confirmación de la contraseña es obligatoria")]
        [StringLength(32, ErrorMessage = "La clave debe estar entre 5 a 32 caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Clave", ErrorMessage = "Clave y confirmar clave deben de ser iguales")]
        [Display(Name = "Confirmar clave")]
        public string ConfirmClave_aux { get; set; }
    }

    public class UserLogin
    {
        [Required(ErrorMessage = "El Login es obligatorio")]
        public string Login { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Clave { get; set; }
    }

    public class LoginResponse
    {
        public string Token { get; set; }
    }
}
