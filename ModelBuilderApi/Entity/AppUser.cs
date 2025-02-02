using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    public class AppUser
    {
        public string PhoneNo { get; set; }
        public string DeviceId { get; set; }
        public string StoreCode { get; set; }
    }
}
