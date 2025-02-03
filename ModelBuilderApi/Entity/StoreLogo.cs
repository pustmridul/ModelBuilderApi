using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class StoreLogo
    {
        public int ID { get; set; }
        public byte[]? Logo { get; set; }
    }
}
