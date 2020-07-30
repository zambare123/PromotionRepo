namespace SKUPromotions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SKU2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PromotionEntities",
                c => new
                    {
                        PromoId = c.Int(nullable: false, identity: true),
                        PromoNm = c.String(),
                        PromoProductNm = c.String(),
                        ProductPromoNumber = c.Double(nullable: false),
                        PromoValue = c.Double(nullable: false),
                        PromoType = c.String(),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                        CreatedDt = c.DateTime(nullable: false),
                        UpdatedDt = c.DateTime(nullable: false),
                        MachineNm = c.String(),
                    })
                .PrimaryKey(t => t.PromoId);
            
            CreateTable(
                "dbo.SKUProductsDetails",
                c => new
                    {
                        SKUProductId = c.Int(nullable: false, identity: true),
                        SKUProductNm = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                        CreatedDt = c.DateTime(nullable: false),
                        UpdatedDt = c.DateTime(nullable: false),
                        MachineNm = c.String(),
                    })
                .PrimaryKey(t => t.SKUProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SKUProductsDetails");
            DropTable("dbo.PromotionEntities");
        }
    }
}
