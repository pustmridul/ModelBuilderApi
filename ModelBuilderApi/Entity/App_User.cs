using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("App_User")]
    public class App_User
    {
        [Key]
        public string PhoneNo { get; set; }
        [Key]
        public string DeviceId { get; set; }
        [Key]
        public string StoreCode { get; set; }
    }
}
