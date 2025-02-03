using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class PLNoteSetup
    {
        public string? TitleName { get; set; }
      
        public string Code { get; set; }
        public decimal? OrderNo { get; set; }

    }
}
