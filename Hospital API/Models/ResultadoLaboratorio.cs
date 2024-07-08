using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_API.Models
{
    public class ResultadoLaboratorio
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int PacienteID { get; set; }

        [Required]
        public int MedicoID { get; set; }

        [Required]
        public int LaboratorioID { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required, MaxLength(100)]
        public string TipoPrueba { get; set; }

        public string Resultados { get; set; }

        [ForeignKey("PacienteID")]
        public Paciente Paciente { get; set; }

        [ForeignKey("MedicoID")]
        public Medico Medico { get; set; }

        [ForeignKey("LaboratorioID")]
        public Laboratorio Laboratorio { get; set; }
    }
}
