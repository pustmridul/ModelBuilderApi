using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class CustomSmsHistory
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string PhoneNo { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public string? Response { get; set; }
        public DateTime SmsDate { get; set; }
        public string CompanyCode { get; set; }
    }
}
