using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class GIFT_VOUCHER_STOCK
    {
        public string? COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? CARD_TYPE { get; set; }
        public decimal QTY { get; set; }
        public decimal DEL_QTY { get; set; }
        public decimal SAL_QTY { get; set; }
        public decimal RTN_QTY { get; set; }
        public decimal BAL_QTY { get; set; }
    }
}
