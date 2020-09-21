namespace ControleDeEstoque.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionarMateriaPrima : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MateriaPrima",
                c => new
                    {
                        MateriaPrimaID = c.String(nullable: false, maxLength: 4),
                        Nome = c.String(maxLength: 60),
                        CAS = c.String(maxLength: 15),
                        CodigoInterno = c.String(maxLength: 10),
                        NCM = c.String(maxLength: 10),
                        Densidade = c.Single(nullable: false),
                        Tipo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MateriaPrimaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MateriaPrima");
        }
    }
}
