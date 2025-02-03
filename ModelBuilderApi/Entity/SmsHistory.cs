using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class SmsHistory
    {
        public DateTime? Date { get; set; }
        public string? MobileNumber { get; set; }
        public string? Message { get; set; }
        public string? Gateway { get; set; }
        public string? Response { get; set; }
        public bool? Status { get; set; }
    }
}
