using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCRUDArreglos.Modelos
{
    [Table("tblOcupaciones")]
    public class Ocupacion
    {
        [Key]

        public int Id {get; set;}
        
        [Required]
        [StringLength(50, ErrorMessage = "50 Cars. Max.")]

        public string? Nombre { get; set; }

        //public bool Inactivo { get; set; }

    }
}
