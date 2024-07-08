using System.ComponentModel.DataAnnotations;

namespace Hospital_API.Models
{
    public class Paciente
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

        [MaxLength(100)]
        public string SeguroMedico { get; set; }

        [MaxLength(20)]
        public string NumeroSeguroSocial { get; set; }

        public ICollection<Cita> Citas { get; set; }
        public ICollection<Hospitalizacion> Hospitalizaciones { get; set; }
        public ICollection<Cirugia> Cirugias { get; set; }
        public ICollection<ResultadoLaboratorio> ResultadosLaboratorio { get; set; }
        public ICollection<Factura> Facturas { get; set; }
    }
}
