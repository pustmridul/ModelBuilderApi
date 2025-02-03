using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class SmsGateway
    {

        public string? GatewayName { get; set; }
        public string? UserName { get; set; }
        public string? ApiKey { get; set; }
        public string? SenderId { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? COMPANY_CODE { get; set; }
    }
}
