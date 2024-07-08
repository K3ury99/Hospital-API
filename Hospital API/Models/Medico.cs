using System.ComponentModel.DataAnnotations;

namespace Hospital_API.Models
{
    public class Medico
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, MaxLength(100)]
        public string Apellido { get; set; }

        [Required, MaxLength(100)]
        public string Especialidad { get; set; }

        [MaxLength(20)]
        public string Telefono { get; set; }

        [MaxLength(100)]
        public string Correo { get; set; }

        public ICollection<Cita> Citas { get; set; }
        public ICollection<Hospitalizacion> Hospitalizaciones { get; set; }
        public ICollection<Cirugia> Cirugias { get; set; }
        public ICollection<ResultadoLaboratorio> ResultadosLaboratorio { get; set; }
    }
}
