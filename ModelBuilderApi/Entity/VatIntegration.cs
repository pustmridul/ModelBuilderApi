using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class VatIntegration
    {
        public bool VAT_INTEGRATION_ENABLED { get; set; }
        public string? VAT_CLIENT { get; set; }
        public string? VAT_TITLE { get; set; }
        public string? VAT_URL { get; set; }
        public string? VAT_USERNAME { get; set; }
        public string? VAT_PASSWORD { get; set; }
        public bool INTEGRATION_WITH_USERBARCODE { get; set; }
    }
}
