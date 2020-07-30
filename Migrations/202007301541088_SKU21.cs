namespace SKUPromotions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SKU21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SKUProductsDetails", "ProductPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.SKUProductsDetails", "SKUProductNm", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SKUProductsDetails", "SKUProductNm", c => c.Int(nullable: false));
            DropColumn("dbo.SKUProductsDetails", "ProductPrice");
        }
    }
}
