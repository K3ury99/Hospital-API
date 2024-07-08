using System.ComponentModel.DataAnnotations;

namespace Hospital_API.Models
{
    public class Medicamento
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [Required]
        public decimal Precio { get; set; }
    }
}
