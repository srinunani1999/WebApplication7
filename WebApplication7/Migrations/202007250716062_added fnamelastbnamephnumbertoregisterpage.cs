namespace WebApplication7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedfnamelastbnamephnumbertoregisterpage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FisrtName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FisrtName");
        }
    }
}
