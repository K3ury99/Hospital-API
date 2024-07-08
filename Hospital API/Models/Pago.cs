using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_API.Models
{
    public class Pago
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int FacturaID { get; set; }

        [Required]
        public DateTime FechaPago { get; set; }

        [Required]
        public decimal MontoPagado { get; set; }

        [Required, MaxLength(100)]
        public string MetodoPago { get; set; }

        [ForeignKey("FacturaID")]
        public Factura Factura { get; set; }
    }
}
