namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsuarioMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        ID_USUARIO = c.Int(nullable: false, identity: true),
                        NOME_USUARIO = c.String(),
                        SENHA_USUARIO = c.String(),
                    })
                .PrimaryKey(t => t.ID_USUARIO);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
        }
    }
}
