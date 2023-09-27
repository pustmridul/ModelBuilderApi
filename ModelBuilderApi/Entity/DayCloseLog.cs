using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("DayCloseLog")]
    public class DayCloseLog
    {
        [Key]
        public string COMPANY_CODE { get; set; }
        [Key]
        public string STORE_CODE { get; set; }
        [Key]
        public DateTime CLOSED_DT { get; set; }
        public decimal? RECEIVED_QTY { get; set; }
        public decimal? TRANSFER_QTY { get; set; }
        public decimal? SAL_QTY { get; set; }
        public decimal? SAL_VAL { get; set; }
        public decimal? SAL_RQTY { get; set; }
        public decimal? SAL_RVAL { get; set; }
        public decimal? NO_INVOICE { get; set; }
        public string TERMINAL_NO { get; set; }
        [Key]
        public string STATUS { get; set; }
        public string? EMPLOYEE_ID { get; set; }
        public DateTime? ENTRY_TIME { get; set; }
        public bool? IsHoliday { get; set; }
        public bool? IsRainyday { get; set; }
        public bool? IsOccasion { get; set; }
        public string? OccasionName { get; set; }
        public string? Temperature { get; set; }
        public string? ThirdPartCreditCustomerSale { get; set; }
        public string? ThridPartyCreditCustomerRequest { get; set; }
        public string? ThirdPartyCreditCustomerResponse { get; set; }
    }
}
