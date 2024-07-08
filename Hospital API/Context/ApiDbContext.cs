using Hospital_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital_API.Context
{
    public class ApiDbContext: DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Tratamiento> Tratamientos { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Prescripcion> Prescripciones { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Hospitalizacion> Hospitalizaciones { get; set; }
        public DbSet<Cirugia> Cirugias { get; set; }
        public DbSet<Laboratorio> Laboratorios { get; set; }
        public DbSet<ResultadoLaboratorio> ResultadosLaboratorio { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Pago> Pagos { get; set; }
    }
}
