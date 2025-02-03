using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class EMPLOYEE
    {
        
        public string EMPLOYEE_CODE { get; set; }
        public string FIRST_NAME { get; set; }
        public string? MIDDLE_NAME { get; set; }
        public string LAST_NAME { get; set; }
      
        public string COMPANY_CODE { get; set; }
        public string STORE_CODE { get; set; }
        public string CONTACT_NO { get; set; }
        public string? EMAIL { get; set; }
        public string ADDRESS1 { get; set; }
        public string? ADDRESS2 { get; set; }
        public string? POSTAL_CODE { get; set; }
        public string CITY { get; set; }
        public string COUNTRY { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string CURRENT_DESIGNATION_CODE { get; set; }
        public decimal CURRENT_SALARY { get; set; }
        public string? USERNAME { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string STATUS { get; set; }
        public decimal REQ_APPROVAL_LIMIT { get; set; }
        public decimal MaxDisPercentAllowed { get; set; }
        public decimal SpecialDiscPercentAllowed { get; set; }
    }
}
