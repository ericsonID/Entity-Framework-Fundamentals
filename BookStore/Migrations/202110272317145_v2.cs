namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Autors", "Nome", c => c.String());
            AlterColumn("dbo.Livroes", "Nome", c => c.String());
            AlterColumn("dbo.Livroes", "ISBN", c => c.String());
            AlterColumn("dbo.Categorias", "Nome", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categorias", "Nome", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Livroes", "ISBN", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Livroes", "Nome", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Autors", "Nome", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
