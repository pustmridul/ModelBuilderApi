using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;
using System.Collections.Generic;
using System.Drawing;

namespace ModelBuilderApi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AgeRange> AgeRanges { get; set; }
      //  public DbSet<App_User> App_Users { get; set; }
        //public DbSet<AREA> AREAS { get; set; }
        public DbSet<BarcodePrintLog> BarcodePrintLogs { get; set; }
        public DbSet<BookingPayment> BookingPayments { get; set; }
        public DbSet<BookingDetails> BookingDetails { get; set; }
        public DbSet<BookingSummary> BookingSummarys { get; set; }
        public DbSet<BRAND> BRANDS { get; set; }
        public DbSet<BRAND_Log> BRAND_Logs { get; set; }
        public DbSet<CancelReason> CancelReasons { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<CashFlow> CashFlows { get; set; }
        public DbSet<CashStatement> CashStatements { get; set; }
        public DbSet<CATEGORY> CATEGORYS { get; set; }
        public DbSet<CATEGORY_Log> CATEGORY_Logs { get; set; }
        public DbSet<CHALLAN_WISE_DISTRIBUTION_PLAN> CHALLAN_WISE_DISTRIBUTION_PLANS { get; set; }
        public DbSet<Circular_Disc_Barcode> Circular_Disc_Barcodes { get; set; }
        public DbSet<CIRCULAR_DISCOUNT> CIRCULAR_DISCOUNTS { get; set; }
        public DbSet<CIRCULAR_PRICE_CHANGE> CIRCULAR_PRICE_CHANGES { get; set; }
        public DbSet<CITY> CITYS { get; set; }
        public DbSet<CLAIM_REASON> CLAIM_REASONS { get; set; }
        public DbSet<COMPANY_INFO> COMPANY_INFOS { get; set; }
        public DbSet<ConsoleSetup> ConsoleSetups { get; set; }
        public DbSet<ConsoleType> ConsoleTypes { get; set; }
        public DbSet<COURIER_LOG> COURIER_LOGS { get; set; }
        public DbSet<CourierChargeRule> CourierChargeRules { get; set; }
        public DbSet<CourierLocation> CourierLocations { get; set; }
        public DbSet<CourierService> CourierServices { get; set; }
        public DbSet<cProfile> cProfiles { get; set; }
        public DbSet<CREDIT_COLLECTION> CREDIT_COLLECTIONS { get; set; }
        public DbSet<CREDIT_NOTE> CREDIT_NOTES { get; set; }
        public DbSet<CUSTOMER> CUSTOMERS { get; set; }
        public DbSet<CUSTOMER_BARCODE> CUSTOMER_BARCODES { get; set; }
        public DbSet<CUSTOMER_CARD> CUSTOMER_CARDS { get; set; }
        public DbSet<CUSTOMER_CREDIT_LEDGER> CUSTOMER_CREDIT_LEDGERS { get; set; }
        public DbSet<CUSTOMER_Log> CUSTOMER_Logs { get; set; }
        public DbSet<CUSTOMER_PRICE_SETUP> CUSTOMER_PRICE_SETUPS { get; set; }
        public DbSet<CUSTOMER_QUOTATION> CUSTOMER_QUOTATIONS { get; set; }
        public DbSet<CustomerExtraField> CustomerExtraFields { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<CustomerType_Log> CustomerType_Logs { get; set; }
        public DbSet<CustomerUpgradationDegradation> CustomerUpgradationDegradations { get; set; }
        public DbSet<PRODUCT> PRODUCTS { get; set; }
        public DbSet<CustomerVoucher> CustomerVouchers { get; set; }
        public DbSet<CustomSmsHistory> CustomSmsHistorys { get; set; }
        public DbSet<DayCloseLog> DayCloseLogs { get; set; }
        public DbSet<DELIVERY_REQUISITION> DELIVERY_REQUISITIONS { get; set; }
        public DbSet<DeliveryPerson> DeliveryPersons { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Department_Log> Department_Logs { get; set; }
        public DbSet<DESIRED_STOCK_SETUP> DESIRED_STOCK_SETUPS { get; set; }
        public DbSet<DISCOUNT_BRAND> DISCOUNT_BRANDS { get; set; }
        public DbSet<DISCOUNT_NONBRAND> DISCOUNT_NONBRANDS { get; set; }
        public DbSet<DO_Company> DO_Companys { get; set; }
        public DbSet<DocPrintLog> DocPrintLogs { get; set; }
        public DbSet<DONOR> DONORS { get; set; }
        public DbSet<EcomExtraFieldSetup> EcomExtraFieldSetups { get; set; }
        public DbSet<EcomMessage> EcomMessages { get; set; }
        public DbSet<EMPLOYEE> EMPLOYEES { get; set; }
        public DbSet<EMPLOYEE_DESIGNATION> EMPLOYEE_DESIGNATIONS { get; set; }
        public DbSet<EMPLOYEE_DESIGNATION_Log> EMPLOYEE_DESIGNATION_Logs { get; set; }
        public DbSet<EmployeeAttachedStore> EmployeeAttachedStores { get; set; }
        public DbSet<ExcessCreditLimit> ExcessCreditLimits { get; set; }
        public DbSet<FreeTextName> FreeTextNames { get; set; }
        public DbSet<GIFT_ITEM_STOCK> GIFT_ITEM_STOCK { get; set; }
        public DbSet<GIFT_VOUCHER_GENERATION> GIFT_VOUCHER_GENERATION { get; set; }
        public DbSet<GIFT_VOUCHER_GENERATION_LOG> GIFT_VOUCHER_GENERATION_LOGS { get; set; }
        public DbSet<GIFT_VOUCHER_STOCK> GIFT_VOUCHER_STOCKS { get; set; }
        public DbSet<GiftVoucherDelivery> GiftVoucherDeliverys { get; set; }
        public DbSet<GiftVoucherDeliveryDetails> GiftVoucherDeliveryDetails { get; set; }
        public DbSet<GlobalSetupGL> GlobalSetupGL { get; set; }
        public DbSet<GLSTRUCTURE> GLSTRUCTURE { get; set; }
        public DbSet<GLTem> GLTems { get; set; }
        public DbSet<INVALID_PRODUCT_SALE_REGISTER> INVALID_PRODUCT_SALE_REGISTER { get; set; }
        public DbSet<INVOICE_CREDIT_LEDGER> INVOICE_CREDIT_LEDGER { get; set; }
        public DbSet<InvoiceDelivery> InvoiceDelivery { get; set; }
        public DbSet<InvTrackingAuditorDetails> InvTrackingAuditorDetails { get; set; }
        public DbSet<InvTrackingDetails> InvTrackingDetails { get; set; }
        public DbSet<InvTrackingDetailsUpdate> InvTrackingDetailsUpdates { get; set; }
        public DbSet<InvTrackingSummary> InvTrackingSummary { get; set; }
        public DbSet<InvTrackingSummaryTemp> InvTrackingSummaryTemp { get; set; }
        public DbSet<LabelSetup> LabelSetup { get; set; }
        public DbSet<LoginLog> LoginLog { get; set; }
        public DbSet<LoyaltyPointsHistory> LoyaltyPointsHistory { get; set; }
        public DbSet<MANUFACTURER> MANUFACTURER { get; set; }
        public DbSet<MEASURING_UNIT> MEASURING_UNIT { get; set; }
        public DbSet<MEASURING_UNIT_Log> MEASURING_UNIT_Log { get; set; }
        public DbSet<MEMBER_POINT_PROMOTION> MEMBER_POINT_PROMOTION { get; set; }
        public DbSet<MENU> MENU { get; set; }
        public DbSet<MenuA> MenuA { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<ORDER> ORDERS { get; set; }
        public DbSet<ORDER_ADDRESS> ORDER_ADDRESS { get; set; }
        public DbSet<ORDER_ADDRESS_EDIT_HIS> ORDER_ADDRESS_EDIT_HIS { get; set; }
        public DbSet<ORDER_DETAILS> ORDER_DETAILS { get; set; }
        public DbSet<ORDER_DETAILS_EDIT_HIS> ORDER_DETAILS_EDIT_HIS { get; set; }
        public DbSet<ORDER_DETAILS_WRK> ORDER_DETAILS_WRK { get; set; }
        public DbSet<ORDER_EDIT_HIS> ORDER_EDIT_HIS { get; set; }
        public DbSet<ORDER_TRACKING> ORDER_TRACKING { get; set; }
        public DbSet<OrderDeliveryScan> OrderDeliveryScan { get; set; }
        public DbSet<OrderLog> OrderLog { get; set; }
        public DbSet<OrderNote> OrderNote { get; set; }
        public DbSet<OtpHistory> OtpHistory { get; set; }
        public DbSet<P_PACKAGE_SALE_REGISTER> P_PACKAGE_SALE_REGISTER { get; set; }
        public DbSet<P_SALE> P_SALE { get; set; }
        public DbSet<P_SALE_PAYMENT> P_SALE_PAYMENT { get; set; }
        public DbSet<P_SSUMMARY> P_SSUMMARY { get; set; }
        public DbSet<PACK_SIZE_LIST> PACK_SIZE_LIST { get; set; }
        public DbSet<PACK_SIZE_LIST_Log> PACK_SIZE_LIST_Log { get; set; }
        public DbSet<PACKAGE_BOOKING_REGISTER> PACKAGE_BOOKING_REGISTER { get; set; }
        public DbSet<PACKAGE_SALE_REGISTER> PACKAGE_SALE_REGISTER { get; set; }
        public DbSet<PAYMENT_METHOD> PAYMENT_METHOD { get; set; }
        public DbSet<PAYMENT_METHOD_Log> PAYMENT_METHOD_Log { get; set; }
        public DbSet<PHYSICAL_PRODUCT_STOCK> PHYSICAL_PRODUCT_STOCK { get; set; }
        public DbSet<PLNoteSetup> PLNoteSetup { get; set; }


    }
}
