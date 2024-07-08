using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_API.Models
{
    public class Departamento
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public ICollection<Empleado> Empleados { get; set; }
    }
}
