namespace Bachelorproef.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class toevoegingDomeinOudProject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Onderzoeksdomeins",
                c => new
                    {
                        OnderzoeksId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.OnderzoeksId);
            
            CreateTable(
                "dbo.Voorstel",
                c => new
                    {
                        StudentId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Titel = c.String(unicode: false),
                        VrijeTrefwoorden = c.String(unicode: false),
                        Probleemstelling = c.String(unicode: false),
                        Onderzoeksvraag = c.String(unicode: false),
                        PlanVanAanpak = c.String(unicode: false),
                        TijdstipVanIndienen = c.DateTime(nullable: false, precision: 0),
                        StateString = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Voorstel");
            DropTable("dbo.Onderzoeksdomeins");
        }
    }
}
