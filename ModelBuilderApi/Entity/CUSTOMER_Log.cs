using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class CustomerLog
    {
       
        public int ID { get; set; }
        public string? CUSTOMER_ID { get; set; }
        public string? CUSTOMER_FIRST_NAME { get; set; }
        public string? CUSTOMER_MIDDLE_NAME { get; set; }
        public string? CUSTOMER_LAST_NAME { get; set; }
        public string? CUSTOMER_ADDRESS { get; set; }
        public string? CUSTOMER_CITY { get; set; }
        public string? CUSTOMER_POSTAL_CODE { get; set; }
        public string? CUTOMER_COUNTRY { get; set; }
        public string? CUSTOMER_PHONE { get; set; }
        public string? CUSTOMER_EMAIL { get; set; }
        public DateTime? CUSTOMER_DOE { get; set; }
        public string? CUSTOMER_TYPE { get; set; }
        public decimal? CUSTOMER_DISC_PRCNT { get; set; }
        public decimal ERN_POINT { get; set; }
        public decimal RDM_POINT { get; set; }
        public decimal BAL_POINT { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string TRANSFER { get; set; }
        public DateTime? EXPIRE_DATE { get; set; }
        public DateTime? DOB { get; set; }
        public string? E_SHOP_CODE { get; set; }
        public bool IS_WHOLESALE { get; set; }
        public bool IS_ZERO_VAT_SAL { get; set; }
        public bool IS_STORESALE { get; set; }
        public string? EMPLOYEE_CODE { get; set; }
        public bool IS_INACTIVE { get; set; }
        public bool IS_CREDIT_CUSTOMER { get; set; }
        public string? ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public bool IS_AUTO_SERIAL { get; set; }
        public string? CARD_NO { get; set; }
        public decimal? CREDIT_LIMIT { get; set; }
        public string? BIN { get; set; }
    }
}
