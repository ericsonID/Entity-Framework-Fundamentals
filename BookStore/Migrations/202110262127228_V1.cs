namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                        ISBN = c.String(nullable: false, maxLength: 30),
                        DataLancamento = c.DateTime(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .Index(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LivroAutors",
                c => new
                    {
                        Livro_Id = c.Int(nullable: false),
                        Autor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Livro_Id, t.Autor_Id })
                .ForeignKey("dbo.Livroes", t => t.Livro_Id, cascadeDelete: true)
                .ForeignKey("dbo.Autors", t => t.Autor_Id, cascadeDelete: true)
                .Index(t => t.Livro_Id)
                .Index(t => t.Autor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livroes", "CategoriaId", "dbo.Categorias");
            DropForeignKey("dbo.LivroAutors", "Autor_Id", "dbo.Autors");
            DropForeignKey("dbo.LivroAutors", "Livro_Id", "dbo.Livroes");
            DropIndex("dbo.LivroAutors", new[] { "Autor_Id" });
            DropIndex("dbo.LivroAutors", new[] { "Livro_Id" });
            DropIndex("dbo.Livroes", new[] { "CategoriaId" });
            DropTable("dbo.LivroAutors");
            DropTable("dbo.Categorias");
            DropTable("dbo.Livroes");
            DropTable("dbo.Autors");
        }
    }
}
