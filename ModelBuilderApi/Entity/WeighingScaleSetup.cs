using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("WeighingScaleSetup")]
    public class WeighingScaleSetup
    {
        public decimal? Barcode_Lenth { get; set; }
        public decimal? Prefix { get; set; }
        public decimal? Item_Code { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Check_Digit { get; set; }
    }
}
