using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    public class AgeRange
    {
        public string RANGE { get; set; }
        public DateTime? UPDATE_DATE { get; set; }
    }
}
