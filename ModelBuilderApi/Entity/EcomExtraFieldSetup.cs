using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("EcomExtraFieldSetup")]
    public class EcomExtraFieldSetup
    {
        public bool? SMSSend { get; set; }
        public bool? Complain { get; set; }
        public bool? Comment { get; set; }
        public bool? Issue { get; set; }
        public bool? CopyOrderMessage { get; set; }
        public bool? ForceConfirm { get; set; }
    }
}
