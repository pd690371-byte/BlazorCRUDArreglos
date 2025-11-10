using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCRUDArreglos.Modelos
{
    [Table("tblDepartamentos")]
    public class Departamento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "50 caracteres máximo.")]
        public string Nombre { get; set; }
    }
}
