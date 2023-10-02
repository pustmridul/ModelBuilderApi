using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("StoreMetaDataRubel")]
    public class StoreMetaDataRubel
    {
        public string? MetaType { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
