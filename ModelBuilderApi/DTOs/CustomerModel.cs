using ModelBuilderApi.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.DTOs
{
    public class CustomerModel
    {
        public string? CUSTOMER_ID { get; set; }
        public string? CARD_NO { get; set; }
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
        public DateTime? EXPIRE_DATE { get; set; }
        public DateTime? DOB { get; set; }
        public string? E_SHOP_CODE { get; set; }
        public string TYPE_CODE { get; set; }
        public string? CUSTOMER_GENDER { get; set; }
        public DateTime? SPECIAL_DATE { get; set; }
        public string? SPECIAL_DATE_NOTE { get; set; }
        public string? AGE_RANGE { get; set; }
        public string? CUSTOMER_TYPE { get; set; }


    }

    #region test
    public class CustomerReq
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
    }
    //public class CustomerTypeVm
    //{
    //    public string? Group_Type { get; set; }
    //    public string Group_Name { get; set; }
    //    public string? Company_Code { get; set; }
    //}
    //public class CustomerTypeReq
    //{
    //    public string? Group_Type { get; set; }

    //    public string Group_Name { get; set; }

    //    public decimal? Discount_Prcnt { get; set; }

    //    public string? Company_Code { get; set; }

    //    public string? Entery_by { get; set; }

    //    public DateTime Entry_date { get; set; }

    //    public string? Updated_by { get; set; }

    //    public DateTime? Updated_date { get; set; }

    //    public string PROMO_PRICE { get; set; }

    //    public bool? SCAN_CARD_ON_SAL { get; set; }
    //    public bool GiftVoucherDeliveryToCustomer { get; set; }
    //}
    #endregion

    #region Customer Data
    public class CustomerDto : CustomerModel
    {
        public int ID { get; set; }
        public decimal? CUSTOMER_DISC_PRCNT { get; set; }
        public decimal ERN_POINT { get; set; }
        public decimal RDM_POINT { get; set; }
        public decimal BAL_POINT { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string TRANSFER { get; set; }
        public bool IS_WHOLESALE { get; set; }
        public bool IS_ZERO_VAT_SAL { get; set; }
        public bool IS_STORESALE { get; set; }
        public string? EMPLOYEE_CODE { get; set; }
        public bool IS_INACTIVE { get; set; }
        public bool IS_CREDIT_CUSTOMER { get; set; }
        public string? ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public bool IS_AUTO_SERIAL { get; set; }
        public decimal? CREDIT_LIMIT { get; set; }
        public string? BIN { get; set; }
        public string? MainChannelCode { get; set; }
        public string? ZoneCode { get; set; }
        public string? CategoryCode { get; set; }
        public string? SubCategoryCode { get; set; }
        public string? LinkId { get; set; }
        public string? CustomerGroup { get; set; }
        public string? ActHead { get; set; }
        public string? STORE_CODE { get; set; }
        public string? CREDIT_ID { get; set; }
        public string? CustomerType { get; set; }
        public string SHIPPING_ADDRESS { get; set; }
        public string CUSTOMER_ALTERNATIVE_PHONE { get; set; }
        public CustomerType CustomerTypes { get; set; }
        public decimal? AccountGLBalance { get; set; }
        public DateTime AccountGLReceiveDate { get; set; }
        public decimal AccountGLLastReceiveAmt { get; set; }
        public decimal AccountGLCreditLimit { get; set; }
        public decimal CreditBalance { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal CreditTerm { get; set; }
        public decimal CreditTerm2 { get; set; }
        // Extra fields
        public decimal RDM_POINT_VAL { get; set; }

    }
    public class CustomerResVm
    {
        public CustomerDto Data { get; set; }
    }
    public class CustomerListVm
    {
        public int DataCount { get; set; }
        public List<CustomerDto> DataList { get; set; }
        public string Message { get; set; }
    }
    #endregion

    #region Card Customer
    public class CustomerCardReq : CustomerModel
    {
        public string TRANSFER { get; set; }
    }
    public class CustomerCardVm
    {
        public CustomerCardReq Data { get; set; }
    }
    public class CustomerCardListVm
    {
        public int DataCount { get; set; }
        public List<CustomerCardReq> DataList { get; set; }
        public string Message { get; set; }
    }
    #endregion

    #region Customer By Id
    public class CustomerByIDReq : CustomerModel
    {
        public string? ActHead { get; set; }
        public string? CREDIT_ID { get; set; }
        public string CUSTOMER_ALTERNATIVE_PHONE { get; set; }
        public decimal BAL_POINT { get; set; }
        public int ID { get; set; }
        public decimal? CUSTOMER_DISC_PRCNT { get; set; }
        public decimal? CREDIT_LIMIT { get; set; }
        public bool IS_CREDIT_CUSTOMER { get; set; }
        public bool IS_ZERO_VAT_SAL { get; set; }
        public string? BIN { get; set; }
        public string? MainChannelCode { get; set; }
        public string? ZoneCode { get; set; }
        public string? CategoryCode { get; set; }
        public string? SubCategoryCode { get; set; }
        public string? CustomerGroup { get; set; }
        public bool IS_INACTIVE { get; set; }


    }
    public class CustomerByIDVm
    {
        public CustomerByIDReq Data { get; set; }
    }
    public class CustomerByIDListVm
    {
        public int DataCount { get; set; }
        public List<CustomerByIDReq> DataList { get; set; }
        public string Message { get; set; }
    }
    #endregion

    #region Customer Type
    public class CustomerTypeReq
    {
        public string? Group_Type { get; set; }

        public string Group_Name { get; set; }

        public decimal? Discount_Prcnt { get; set; }

        public string? Company_Code { get; set; }

        public string? Entery_by { get; set; }

        public DateTime Entry_date { get; set; }

        public string? Updated_by { get; set; }

        public DateTime? Updated_date { get; set; }

        public string PROMO_PRICE { get; set; }

        public bool? SCAN_CARD_ON_SAL { get; set; }
        public bool GiftVoucherDeliveryToCustomer { get; set; }


    }
    public class CustomerTypeVm
    {
        public CustomerTypeReq Data { get; set; }
    }
    public class CustomerTypeListVm
    {
        public int DataCount { get; set; }
        public List<CustomerTypeReq> DataList { get; set; }
        public string Message { get; set; }
    }

    #endregion

}