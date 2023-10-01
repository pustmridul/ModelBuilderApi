using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("ProductPeriodicalBarcodewiseData")]
    public class ProductPeriodicalBarcodewiseData
    {
        public DateTime? EntryDate { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string? BarCode { get; set; }
        public string? STORE_CODE { get; set; }
        public decimal? RCV_QTY { get; set; }
        public decimal? PUR_RCV_SALE_VALUE { get; set; }
        public decimal? PUR_RCV_COST_VALUE { get; set; }
        public decimal? PUR_RTN_QTY { get; set; }
        public decimal? PUR_SALE_VALUE { get; set; }
        public decimal? PUR_COST_VALUE { get; set; }
        public decimal? store_rcvQty { get; set; }
        public decimal? store_rcvValue { get; set; }
        public decimal? store_rcvCostValue { get; set; }
        public decimal? transfer_qty { get; set; }
        public decimal? transfer_SALE_VALUE { get; set; }
        public decimal? transfer_COST_VALUE { get; set; }
        public decimal? dml_qty { get; set; }
        public decimal? dml_SALE_VALUE { get; set; }
        public decimal? dml_COST_VALUE { get; set; }
        public decimal? sal_qty { get; set; }
        public decimal? sal_qty_SaleValue { get; set; }
        public decimal? sal_qty_CostValue { get; set; }
        public decimal? adjqty { get; set; }
        public decimal? adjqty_SaleValue { get; set; }
        public decimal? adjqty_CostValue { get; set; }
        public decimal? opening_stock { get; set; }
        public decimal? OpeningValue { get; set; }
        public decimal? OpeningCostValue { get; set; }
        public decimal? CONV_IN { get; set; }
        public decimal? CONV_OUT { get; set; }
        public decimal? CLOSINGQTY { get; set; }
        public decimal? ClosingValue { get; set; }
        public decimal? ClosingCostValue { get; set; }
        public string? SAL_BARCODE { get; set; }
    }
}
