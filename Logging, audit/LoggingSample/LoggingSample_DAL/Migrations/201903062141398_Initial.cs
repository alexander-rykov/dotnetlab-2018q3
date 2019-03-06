namespace LoggingSample_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        address = c.String(),
                        city = c.String(),
                        state = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        total_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        customer_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.customer", t => t.customer_id, cascadeDelete: true)
                .Index(t => t.customer_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.order", "customer_id", "dbo.customer");
            DropIndex("dbo.order", new[] { "customer_id" });
            DropTable("dbo.order");
            DropTable("dbo.customer");
        }
    }
}
