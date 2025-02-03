using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class ProductExtraFieldSetup
    {
        public bool? ProductDescription { get; set; }
        public bool? RegionalName { get; set; }
        public bool? CountryOfOrgin { get; set; }
        public bool? UserBarcode { get; set; }
        public bool? MasterBarcode { get; set; }
        public bool? StyleCode { get; set; }
        public bool? FreeText1 { get; set; }
        public bool? FreeText2 { get; set; }
        public bool? FreeText3 { get; set; }
        public bool? FreeText4 { get; set; }
        public bool? FreeText5 { get; set; }
        public bool? GpOnMrp { get; set; }
        public bool? GpOnCost { get; set; }
        public bool? SD { get; set; }
        public bool? Price1 { get; set; }
        public bool? Price2 { get; set; }
        public bool? Price3 { get; set; }
        public bool? Price4 { get; set; }
        public bool? WearhouseShelfLocation { get; set; }
        public bool? MinimumStockQty { get; set; }
        public bool? OpeningQty { get; set; }
        public bool? ProductImage { get; set; }
        public bool? ConvertableProduct { get; set; }
        public bool? IsDiscExemption { get; set; }
        public bool? IsMemberPointExemption { get; set; }
        public bool? IsEcProduct { get; set; }
        public bool? IsScale { get; set; }
        public bool? IsNotForSale { get; set; }
        public bool? ReorderQty { get; set; }
        public bool? ZeroPriceSale { get; set; }
        public bool? PurchaseVat { get; set; }
        public bool? ShowSimpleProduct { get; set; }
        public bool? ShowVariableProduct { get; set; }
        public bool? ShowServiceProduct { get; set; }
        public string? DefaultProduct { get; set; }
        public bool ProductName { get; set; }
        public bool? BSTI { get; set; }
        public bool? ProductNameAutoSuggestion { get; set; }
        public bool? DescriptionAutoSuggestion { get; set; }
        public bool? TrackReceiveSerial { get; set; }
        public bool? ShowParentProduct { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsNegative { get; set; }
        public bool? IsManageStock { get; set; }
        public bool? ManufacturerDate { get; set; }
        public bool? ExpireDate { get; set; }
        public bool? BatchRequired { get; set; }
        public bool CircularDiscount { get; set; }
        public bool? CircularDiscountV2 { get; set; }
        public bool? Package { get; set; }
        public bool? BuyGet { get; set; }
        public bool? MonthYear { get; set; }
        public bool? Coupon { get; set; }
        public bool? BuyNGetCate { get; set; }
        public bool? BuyNGetLowest { get; set; }
        public bool? AttributeDiscount { get; set; }
        public string DefaultPromotion { get; set; }
        public bool? ShowStockInfo { get; set; }
        public bool? DefaultAutoScan { get; set; }
        public bool? ShowStoreStockOnPriceChange { get; set; }
        public bool? InvoiceDiscount { get; set; }
        public bool? InvoiceGiftCoupon { get; set; }
        public bool? CPUAverageOptions { get; set; }
        public bool ShowConvertionUnit { get; set; }
        public bool ProductDisplayName { get; set; }
        public bool ShowHSCode { get; set; }
        public bool ShowCartonSize { get; set; }
        public bool? FreeText6 { get; set; }
        public bool? FreeText7 { get; set; }
        public bool? FreeText8 { get; set; }
        public bool? FreeText9 { get; set; }
        public bool? FreeText10 { get; set; }
        public bool AutoScanInPurchaseReturn { get; set; }
        public bool AutoScanInDamageReturn { get; set; }
        public bool HappyHourPromotion { get; set; }
        public bool PickOffPick { get; set; }
        public bool ShelfLifeDays { get; set; }
        public bool SHOW_SHOP_DIVISION { get; set; }
        public bool SHOW_SHOP_DISTRICT { get; set; }
        public bool SHOW_SHOP_TYPE { get; set; }
        public bool SHOW_SHOP_CATEGORY { get; set; }
        public bool Reduction { get; set; }
        public bool? BuyAmountGetItemFree { get; set; }
        public bool? BuyAmountGetItemDiscount { get; set; }
        public bool PurReturnWithRefNo { get; set; }
        public bool PaymentMethodDiscount { get; set; }

    }
}
