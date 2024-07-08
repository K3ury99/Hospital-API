using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_API.Models
{
    public class Hospitalizacion
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int PacienteID { get; set; }

        [Required]
        public int MedicoID { get; set; }

        [Required]
        public DateTime FechaIngreso { get; set; }

        public DateTime? FechaAlta { get; set; }

        public string Motivo { get; set; }

        [ForeignKey("PacienteID")]
        public Paciente Paciente { get; set; }

        [ForeignKey("MedicoID")]
        public Medico Medico { get; set; }
    }
}
