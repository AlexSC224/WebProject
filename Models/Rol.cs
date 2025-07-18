using System.ComponentModel.DataAnnotations;

namespace WebAppMvc.Models
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre del Rol")]
        public string Nombre { get; set; }
        public List<Persona> Personas { get; set; } = new List<Persona>();
    }
}
