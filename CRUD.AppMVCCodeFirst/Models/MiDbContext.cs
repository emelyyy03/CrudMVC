using Microsoft.EntityFrameworkCore;

namespace CRUD.AppMVCCodeFirst.Models
{
    public class MiDbContext : DbContext
    {
        public MiDbContext(DbContextOptions<MiDbContext> options) : base(options) { }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
