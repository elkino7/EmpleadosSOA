using System.Data.Entity;

namespace EmpleadosMVC.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Antiguedad { get; set; }
        public int Edad { get; set; }
        public string Categoria { get; set; }
    }
    public class EmpleadoDBContext : DbContext 
    {
        public DbSet<Empleado> Empleados { get; set; }
    }
}