using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class DeliveryPerson
    {
        public string? PERSON_ID { get; set; }
        public string? FULLNAME { get; set; }
        public string? CONTACT_NO { get; set; }
        public string? EMAIL { get; set; }
        public string? ADDRESSLINE1 { get; set; }
        public string? ADDRESSLINE2 { get; set; }
        public string? DISTRICT { get; set; }
        public string? CREATED_BY { get; set; }
        public DateTime? CREATION_DATE { get; set; }
        public string? UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public string? COMPANY_CODE { get; set; }

    }
}
