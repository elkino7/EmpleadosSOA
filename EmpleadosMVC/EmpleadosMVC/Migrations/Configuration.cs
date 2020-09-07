using EmpleadosMVC.Models;
using System.Data.Entity.Migrations;

namespace EmpleadosMVC.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EmpleadosMVC.Models.EmpleadoDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmpleadosMVC.Models.EmpleadoDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Empleados.AddOrUpdate(i => i.Nombre, new Empleado
            {
                Nombre = "Angel Arias",
                Antiguedad = 15,
                Edad = 38,
                Categoria = "A"
            },

                new Empleado
                {
                    Nombre = "ELkin Ortiz",
                    Antiguedad = 15,
                    Edad = 36,
                    Categoria = "A"
                },
                new Empleado
                {
                    Nombre = "Julio Morales",
                    Antiguedad = 4,
                    Edad = 25,
                    Categoria = "B"
                },

                new Empleado
                {
                    Nombre = "Natali Salamanca",
                    Antiguedad = 8,
                    Edad = 34,
                    Categoria = "B"
                },

                new Empleado
                {
                    Nombre = "Cesar Torres",
                    Antiguedad = 2,
                    Edad = 35,
                    Categoria = "C"
                },

                new Empleado
                {
                    Nombre = "Jacobo Salazar",
                    Antiguedad = 5,
                    Edad = 28,
                    Categoria = "C"
                },

                new Empleado
                {
                    Nombre = "Henry Casas",
                    Antiguedad = 3,
                    Edad = 33,
                    Categoria = "C"
                }
                );

        }
    }
}
