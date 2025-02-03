using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class EcomMessage
    {
        public int? ID { get; set; }
        public string? Operation { get; set; }
        public string? Message { get; set; }
    }
}
