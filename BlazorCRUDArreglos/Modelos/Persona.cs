using BlazorCRUDArreglos.Components.Pages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BlazorCRUDArreglos.Modelos
{
    [Table("tblPersonas")]
    public class Persona
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        public string? Apellido { get; set; }
    }
}
