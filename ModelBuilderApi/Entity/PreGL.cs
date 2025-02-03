using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class PreGL
    {
        public string CMPIDX { get; set; }
        public string? VNUMBER { get; set; }
        public DateTime? vDATE { get; set; }
        public string? ACTCODE { get; set; }
        public string? MOD_PAY { get; set; }
        public DateTime? CHK_DT { get; set; }
        public decimal? DAMOUNT { get; set; }
        public decimal? CAMOUNT { get; set; }
        public string? DESCRP { get; set; }
        public string? OPB { get; set; }
        public string? BANK { get; set; }
        public string? ActName { get; set; }
        public string? CHK_NO { get; set; }
        public string? Cash { get; set; }
        public string? UserID { get; set; }
        public string? Net_Code { get; set; }
        public string? StmntNo { get; set; }
        public string? chln { get; set; }
        public string? PASSED { get; set; }
        public DateTime? PASSEDDT { get; set; }
        public string? PASSEDBY { get; set; }
        public string? CostCenterID { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? isVoucherEntry { get; set; }
        public string? CheckPrint { get; set; }
    }
}
