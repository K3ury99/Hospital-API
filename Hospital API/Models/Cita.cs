using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_API.Models
{
    public class Cita
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int PacienteID { get; set; }

        [Required]
        public int MedicoID { get; set; }

        [Required]
        public DateTime FechaHora { get; set; }

        public string Motivo { get; set; }

        [ForeignKey("PacienteID")]
        public Paciente Paciente { get; set; }

        [ForeignKey("MedicoID")]
        public Medico Medico { get; set; }

        public ICollection<Prescripcion> Prescripciones { get; set; }
    }
}
