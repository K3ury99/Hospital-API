using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_API.Models
{
    public class Cirugia
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int PacienteID { get; set; }

        [Required]
        public int MedicoID { get; set; }

        [Required]
        public DateTime FechaHora { get; set; }

        [Required, MaxLength(100)]
        public string TipoCirugia { get; set; }

        public string Descripcion { get; set; }

        [ForeignKey("PacienteID")]
        public Paciente Paciente { get; set; }

        [ForeignKey("MedicoID")]
        public Medico Medico { get; set; }
    }
}
