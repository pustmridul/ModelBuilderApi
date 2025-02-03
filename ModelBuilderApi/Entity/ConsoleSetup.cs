using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class ConsoleSetup
    {
        public string ConsoleID { get; set; }
        public string ConsoleName { get; set; }
        public string ConsoleType { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
