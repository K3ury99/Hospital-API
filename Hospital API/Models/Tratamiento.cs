using System.ComponentModel.DataAnnotations;

namespace Hospital_API.Models
{
    public class Tratamiento
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
    }
}
