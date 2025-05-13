using System.ComponentModel.DataAnnotations;

namespace WebApi2025.DAL.Entities
{
    public class Country: AuditBase
    {
        [Display(Name = "Pais")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }
    }
}
