using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class CourierLocation
    {
        
        public string LOCATION_CODE { get; set; }
        public long? LOCATION_ID { get; set; }
        public string LOCATION_NAME { get; set; }
        public string? COURIER_ID { get; set; }
        public string? COURIER_NAME { get; set; }
        public string DISTRICT { get; set; }
        public string THANA { get; set; }
        public string? CREATED_BY { get; set; }
        public DateTime? CREATION_DATE { get; set; }
        public string? UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public decimal? COURIER_CHARGE { get; set; }
        public decimal? COURIER_ACTUAL_CHARGE { get; set; }
        public decimal? COURIER_RETURN_CHARGE { get; set; }
        public string? LOCATION_TYPE { get; set; }
        public string? POSTALCODE { get; set; }
        public decimal? ExpressCharge { get; set; }
        public decimal? OverseasCharge { get; set; }
    }
}
