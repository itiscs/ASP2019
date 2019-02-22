namespace FirstEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAmountBook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Amount");
        }
    }
}
