using System.ComponentModel.DataAnnotations;

namespace WebAppMvc.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El rol es obligatorio")]
        [Display(Name = "Rol")]
        public int RolId { get; set; }
        public Rol? Rol { get; set; }
    }
}
