using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class LabelSetup
    {
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string Design1 { get; set; }
        public string Design2 { get; set; }
        public string Design3 { get; set; }
        public string Design4 { get; set; }
        public string Design5 { get; set; }
        public string ShelfTag { get; set; }
    }
}
