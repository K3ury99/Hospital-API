using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_API.Models
{
    public class Factura
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int PacienteID { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public decimal MontoTotal { get; set; }

        public string Descripcion { get; set; }

        [ForeignKey("PacienteID")]
        public Paciente Paciente { get; set; }

        public ICollection<Pago> Pagos { get; set; }
    }
}
