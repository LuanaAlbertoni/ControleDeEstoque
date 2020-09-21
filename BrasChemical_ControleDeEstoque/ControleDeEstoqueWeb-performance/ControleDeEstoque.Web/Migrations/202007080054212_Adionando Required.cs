namespace ControleDeEstoque.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdionandoRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MateriaPrima", "Nome", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MateriaPrima", "Nome", c => c.String(maxLength: 60));
        }
    }
}
