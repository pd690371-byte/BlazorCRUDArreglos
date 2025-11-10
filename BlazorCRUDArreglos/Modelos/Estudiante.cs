using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCRUDArreglos.Modelos
{
    [Table("tblEstudiantes")]
    public class Estudiante
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "11 caracteres máximo.")]
        [DisplayName("Matrícula")]
        public string? Matricula { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "11 caracteres máximo.")]
        [DisplayName("Cédula")]
        public string? Cedula { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "30 caracteres máximo.")]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "30 caracteres máximo.")]
        public string Apellido { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "10 caracteres máximo.")]
        public string Sexo { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "15 caracteres máximo.")]
        public string EstadoCivil { get; set; }

        [StringLength(5, ErrorMessage = "5 caracteres máximo.")]
        public string TipoSangre { get; set; }

        [StringLength(50, ErrorMessage = "50 caracteres máximo.")]
        public string Nacionalidad { get; set; }

        [StringLength(50, ErrorMessage = "50 caracteres máximo.")]
        [DisplayName("Religión")]
        public string Religion { get; set; }

        [StringLength(20, ErrorMessage = "20 caracteres máximo.")]
        [DisplayName("Teléfono")]
        public string Telefono { get; set; }

        [StringLength(50, ErrorMessage = "50 caracteres máximo.")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "100 caracteres máximo.")]
        [DisplayName("Dirección")]
        public string Direccion { get; set; }

        [StringLength(50, ErrorMessage = "50 caracteres máximo.")]
        public string NombrePadre { get; set; }

        [StringLength(50, ErrorMessage = "50 caracteres máximo.")]
        public string NombreMadre { get; set; }

        [StringLength(15, ErrorMessage = "15 caracteres máximo.")]
        public string TipoColegioEstudios { get; set; }

        [StringLength(50, ErrorMessage = "50 caracteres máximo.")]
        public string Carrera { get; set; }

        [StringLength(300, ErrorMessage = "300 caracteres máximo.")]
        public string Observaciones { get; set; }

        [StringLength(50, ErrorMessage = "50 caracteres máximo.")]
        [DisplayName("Ocupación")]
        public string Ocupacion { get; set; }

        //public bool Inactivo { get; set; }
    }
}
