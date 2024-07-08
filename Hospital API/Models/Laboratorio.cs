using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_API.Models
{
    public class Laboratorio
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [MaxLength(255)]
        public string Direccion { get; set; }

        [MaxLength(20)]
        public string Telefono { get; set; }

        [MaxLength(100)]
        public string Correo { get; set; }

        public ICollection<ResultadoLaboratorio> ResultadosLaboratorio { get; set; }
    }
}
