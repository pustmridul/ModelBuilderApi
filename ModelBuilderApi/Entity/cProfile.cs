using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("cProfile")]
    public class cProfile
    {
        public string? ceo { get; set; }
        public string? company { get; set; }
        public string? Address { get; set; }
        public string? add1 { get; set; }
        public string? add2 { get; set; }
        public string? tel { get; set; }
        public string? Slogan { get; set; }
    }
}
