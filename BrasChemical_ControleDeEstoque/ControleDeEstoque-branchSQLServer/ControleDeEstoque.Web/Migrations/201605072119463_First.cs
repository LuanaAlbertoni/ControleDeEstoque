namespace ControleDeEstoque.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estoque",
                c => new
                    {
                        LoteID = c.String(nullable: false, maxLength: 20),
                        ProdutoID = c.Int(nullable: false),
                        QuantidadeProduzida = c.Int(nullable: false),
                        QuantidadeDisponivel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LoteID, t.ProdutoID })
                .ForeignKey("dbo.Produto", t => t.ProdutoID)
                .ForeignKey("dbo.OrdemFabricacao", t => t.LoteID)
                .Index(t => t.LoteID)
                .Index(t => t.ProdutoID);
            
            CreateTable(
                "dbo.Expedicao",
                c => new
                    {
                        ExpedicaoID = c.Int(nullable: false, identity: true),
                        EstoqueLoteID = c.String(maxLength: 20),
                        EstoqueProdutoID = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExpedicaoID)
                .ForeignKey("dbo.Estoque", t => new { t.EstoqueLoteID, t.EstoqueProdutoID })
                .Index(t => new { t.EstoqueLoteID, t.EstoqueProdutoID });
            
            CreateTable(
                "dbo.OrdemFabricacao",
                c => new
                    {
                        LoteID = c.String(nullable: false, maxLength: 20),
                        PreProdutoID = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Envasado = c.Boolean(nullable: false),
                        DataProducao = c.DateTime(),
                    })
                .PrimaryKey(t => t.LoteID)
                .ForeignKey("dbo.PreProduto", t => t.PreProdutoID)
                .Index(t => t.PreProdutoID);
            
            CreateTable(
                "dbo.PreProduto",
                c => new
                    {
                        PreProdutoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 60),
                        Sigla = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.PreProdutoID);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 60),
                        Litros = c.Int(nullable: false),
                        PreProdutoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoID)
                .ForeignKey("dbo.PreProduto", t => t.PreProdutoID)
                .Index(t => t.PreProdutoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estoque", "LoteID", "dbo.OrdemFabricacao");
            DropForeignKey("dbo.Produto", "PreProdutoID", "dbo.PreProduto");
            DropForeignKey("dbo.Estoque", "ProdutoID", "dbo.Produto");
            DropForeignKey("dbo.OrdemFabricacao", "PreProdutoID", "dbo.PreProduto");
            DropForeignKey("dbo.Expedicao", new[] { "EstoqueLoteID", "EstoqueProdutoID" }, "dbo.Estoque");
            DropIndex("dbo.Produto", new[] { "PreProdutoID" });
            DropIndex("dbo.OrdemFabricacao", new[] { "PreProdutoID" });
            DropIndex("dbo.Expedicao", new[] { "EstoqueLoteID", "EstoqueProdutoID" });
            DropIndex("dbo.Estoque", new[] { "ProdutoID" });
            DropIndex("dbo.Estoque", new[] { "LoteID" });
            DropTable("dbo.Produto");
            DropTable("dbo.PreProduto");
            DropTable("dbo.OrdemFabricacao");
            DropTable("dbo.Expedicao");
            DropTable("dbo.Estoque");
        }
    }
}
