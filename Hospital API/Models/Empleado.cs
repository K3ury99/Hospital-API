using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_API.Models
{
    public class Empleado
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, MaxLength(100)]
        public string Apellido { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required, StringLength(1)]
        [RegularExpression("M|F")]
        public string Genero { get; set; }

        [MaxLength(255)]
        public string Direccion { get; set; }

        [MaxLength(20)]
        public string Telefono { get; set; }

        [MaxLength(100)]
        public string Correo { get; set; }

        [Required]
        public int DepartamentoID { get; set; }

        [Required, MaxLength(100)]
        public string Cargo { get; set; }

        [ForeignKey("DepartamentoID")]
        public Departamento Departamento { get; set; }
    }
}
