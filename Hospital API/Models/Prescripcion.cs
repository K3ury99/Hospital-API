using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_API.Models
{
    public class Prescripcion
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int CitaID { get; set; }

        [Required]
        public int MedicamentoID { get; set; }

        [Required, MaxLength(100)]
        public string Dosis { get; set; }

        [Required]
        public int Duracion { get; set; }

        public string Instrucciones { get; set; }

        [ForeignKey("CitaID")]
        public Cita Cita { get; set; }

        [ForeignKey("MedicamentoID")]
        public Medicamento Medicamento { get; set; }
    }
}
