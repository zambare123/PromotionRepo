namespace SKUPromotions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SKU22 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PromotionEntities", "ProductPromoNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PromotionEntities", "ProductPromoNumber", c => c.Double(nullable: false));
        }
    }
}
