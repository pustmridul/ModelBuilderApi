using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class CustomerUpgradationDegradation
    {
        public string Code { get; set; }
        public string UDType { get; set; }
        public decimal MinPoint { get; set; }
        public string FromType { get; set; }
        public string ToType { get; set; }
        public string Company_Code { get; set; }
        public string Entery_By { get; set; }
        public DateTime Entry_Date { get; set; }
        public string Status { get; set; }
        public string? Updated_By { get; set; }
        public DateTime? Updated_Date { get; set; }
    }
}
