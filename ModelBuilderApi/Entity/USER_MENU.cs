using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class USER_MENU
    {
        public decimal SERIAL { get; set; }
        public decimal? PARENT_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public string? URL { get; set; }
        public string USER_NAME { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public decimal ORDER_BY { get; set; }
        public string? FA_CLASS { get; set; }
        public int ID { get; set; }
        public string MENU_TYPE { get; set; }
        public bool SHOW_CPU { get; set; }
        public bool EDIT_PERMISSION { get; set; }
    }
}
