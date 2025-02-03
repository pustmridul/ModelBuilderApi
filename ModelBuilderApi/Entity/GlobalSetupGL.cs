using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class GlobalSetupGL
    {
       
        public decimal ID { get; set; }
        public DateTime FiscYr { get; set; }
        public DateTime? FiscYr2 { get; set; }
        public string? DeprnControlCode { get; set; }
        public string? FACONTROLCODE { get; set; }
        public string? AccumDeprnControlCode { get; set; }
        public string? SupControlCode { get; set; }
        public string? RetainEarnings { get; set; }
        public string? CashCode { get; set; }
        public string? BankCode { get; set; }
        public string? PurchaseCode { get; set; }
        public string? DeprnPeriod { get; set; }
        public string? SingleChart { get; set; }
        public string? PreGLReq { get; set; }
        public string? CompanyId { get; set; }
        public string? IsVoucherIntegrationMenu { get; set; }
        public string? IsVoucherIntegrationMenu2 { get; set; }
        public string? IsMultiCash { get; set; }
        public string? IsCashNegativeEnabled { get; set; }
        public string? IsCategoryWiseCostCenter { get; set; }
    }
}
