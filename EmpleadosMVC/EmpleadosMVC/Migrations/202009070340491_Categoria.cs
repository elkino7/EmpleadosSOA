using System;
using System.Data.Entity.Migrations;

namespace EmpleadosMVC.Migrations
{
    public partial class Categoria : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleadoes", "Categoria", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empleadoes", "Categoria");
        }
    }
}
