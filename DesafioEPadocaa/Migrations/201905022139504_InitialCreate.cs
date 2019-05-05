namespace DesafioEPadocaa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.padarias",
                c => new
                    {
                        codigo = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        telefone = c.Int(nullable: false),
                        endereco = c.String(),
                        cnpj = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.codigo)
                .Index(t => t.cnpj, unique: true, name: "cnpj");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.padarias", "cnpj");
            DropTable("dbo.padarias");
        }
    }
}
