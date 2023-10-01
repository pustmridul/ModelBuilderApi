using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PLNoteSetup")]
    public class PLNoteSetup
    {
        public string? TitleName { get; set; }
        [Key]
        public string Code { get; set; }
        public decimal? OrderNo { get; set; }

    }
}
