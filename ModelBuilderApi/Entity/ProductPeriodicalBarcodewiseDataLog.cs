using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("ProductPeriodicalBarcodewiseDataLog")]
    public class ProductPeriodicalBarcodewiseDataLog
    {
        public string Message { get; set; }
        public string Status { get; set; }
        public DateTime DATE {get;set;}
}
}
