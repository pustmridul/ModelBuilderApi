using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class VENDOR_CONTACT
    {

       
        public string COMPANY_CODE { get; set; }
        public string? STORE_CODE { get; set; }
       
        public string VENDOR_CODE { get; set; }
        public string? CONTACT_TYPE { get; set; }
        public string? NAME { get; set; }
        public string? DESIGNATION { get; set; }
        public string? PHONE { get; set; }
        public string? EMAIL { get; set; }
    }
}
