using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class VENDOR_ADDITIONAL_INFO
    {
       
        public string COMPANY_CODE { get; set; }
        public string? VENDOR_CODE { get; set; }
      
        public string TRD_NAME { get; set; }
        public string? TRD_ADDRESS { get; set; }
        public string? TRD_POSTAL_CODE { get; set; }
        public string? TRD_CITY { get; set; }
        public string? TRD_COUNTRY { get; set; }
        public string? TRD_CONTACT_NO { get; set; }
        public string? TRD_EMAIL { get; set; }
        public string? TRD_WEBSITE { get; set; }
        public string M_OR_D { get; set; }
        public string? RG_C_NAME { get; set; }
        public string? RG_C_DESIGNATION { get; set; }
        public string? RG_C_MOBILE { get; set; }
        public string? RG_C_EMAIL { get; set; }
        public string? MG_C_NAME { get; set; }
        public string? MG_C_DESIGNATION { get; set; }
        public string? MG_C_MOBILE { get; set; }
        public string? MG_C_EMAIL { get; set; }
        public string? MK_C_NAME { get; set; }
        public string? MK_C_DESIGNATION { get; set; }
        public string? MK_C_MOBILE { get; set; }
        public string? MK_C_EMAIL { get; set; }
        public string? FC_C_NAME { get; set; }
        public string? FC_C_DESIGNATION { get; set; }
        public string? FC_C_MOBILE { get; set; }
        public string? FC_C_EMAIL { get; set; }
        public string GROSS_MARGIN_ON { get; set; }
        public decimal MARGIN_RATE { get; set; }
        public string? SUPPLY_SCHEDULE { get; set; }
        public decimal DELIVERY_DAY { get; set; }
        public string? MODE_OF_TRANSPORT { get; set; }
        public decimal PRICE_CHNG_NOTIC_DAY { get; set; }
        public string? SPECIAL_DISC_ON { get; set; }
        public decimal SPECIAL_DISC { get; set; }
        public string? BNK_NAME { get; set; }
        public string? BRN_NAME { get; set; }
        public string? AC_NAME { get; set; }
        public string? AC_NO { get; set; }
        public string? ADJ_DAMAGE { get; set; }
        public string? ADJ_SLW_MOV { get; set; }
        public string? ADJ_SHT_DATE { get; set; }
        public string? ADJ_EXP_PRD { get; set; }
        public string? VENDOR_TYPE { get; set; }
        public decimal ENC_TRAD_LIC { get; set; }
        public decimal ENC_BSTI_DOC { get; set; }
        public decimal ENC_VAT_CRT { get; set; }
        public decimal ENC_TIN_CRT { get; set; }
        public decimal ENC_OTH_DOC { get; set; }
        public string? OTH_DOC { get; set; }
        public string? ROUTING_NO { get; set; }
        public string ENC_TRAD_LIC_FILE_URL { get; set; }
        public string ENC_BSTI_DOC_FILE_URL { get; set; }
        public string ENC_VAT_CRT_FILE_URL { get; set; }
        public string ENC_TIN_CRT_FILE_URL { get; set; }
        public string ENC_OTH_DOC_FILE_URL { get; set; }
    }
}
