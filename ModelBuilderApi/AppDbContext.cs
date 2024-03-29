﻿using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;
using ModelBuilderApi.QueryResultModels;
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
        public DbSet<PointEarnPolicy> PointEarnPolicy { get; set; }
        public DbSet<PreGL> PreGL { get; set; }
        public DbSet<PREGLStructure> PREGLStructure { get; set; }
        public DbSet<PRIORITY> PRIORITY { get; set; }
        public DbSet<ProcessedInvoice> ProcessedInvoice { get; set; }
        public DbSet<PRODUCT_ALLOCATION_RATIO> PRODUCT_ALLOCATION_RATIO { get; set; }
        public DbSet<PRODUCT_ATTRIBUTE> PRODUCT_ATTRIBUTE { get; set; }
        public DbSet<PRODUCT_BARCODE> PRODUCT_BARCODE { get; set; }
        public DbSet<PRODUCT_BOM> PRODUCT_BOM { get; set; }
        public DbSet<PRODUCT_CARTON> PRODUCT_CARTON { get; set; }
        public DbSet<PRODUCT_CONVERSION> PRODUCT_CONVERSION { get; set; }
        public DbSet<PRODUCT_CONVERSION_SUMMARY> PRODUCT_CONVERSION_SUMMARY { get; set; }
        public DbSet<PRODUCT_CONVERTION_SETUP> PRODUCT_CONVERTION_SETUP { get; set; }
        public DbSet<PRODUCT_DELETE_LOG> PRODUCT_DELETE_LOG { get; set; }
        public DbSet<PRODUCT_FILE> PRODUCT_FILE { get; set; }
        public DbSet<Product_FileRubel> Product_FileRubel { get; set; }
        public DbSet<PRODUCT_HIS> PRODUCT_HIS { get; set; }
        public DbSet<PRODUCT_OPTIONS> PRODUCT_OPTIONS { get; set; }
        public DbSet<PRODUCT_STOCK> PRODUCT_STOCK { get; set; }
        public DbSet<PRODUCT_STOCK23AUG2022> PRODUCT_STOCK23AUG2022 { get; set; }
        public DbSet<PRODUCT_VARIANCE> PRODUCT_VARIANCE { get; set; }
        public DbSet<PRODUCT_VARIANCE_SEQUENCE> PRODUCT_VARIANCE_SEQUENCE { get; set; }
        public DbSet<PRODUCT_VENDOR> PRODUCT_VENDOR { get; set; }
        public DbSet<PRODUCT_VENDOR_USER_BARCODE> PRODUCT_VENDOR_USER_BARCODE { get; set; }
        public DbSet<ProductColumnDefine> ProductColumnDefine { get; set; }
        public DbSet<ProductConversionWrk> ProductConversionWrk { get; set; }
        public DbSet<ProductExtraFieldSetup> ProductExtraFieldSetup { get; set; }
        public DbSet<Production> Production { get; set; }
        public DbSet<ProductionIng> ProductionIng { get; set; }
        public DbSet<ProductPeriodicalBarcodewiseData> ProductPeriodicalBarcodewiseData { get; set; }
        public DbSet<ProductPeriodicalBarcodewiseDataLog> ProductPeriodicalBarcodewiseDataLog { get; set; }
        public DbSet<ProductRubel> ProductRubel { get; set; }
        public DbSet<PROMOTION> PROMOTION { get; set; }
        public DbSet<PROMOTION_BUY> PROMOTION_BUY { get; set; }
        public DbSet<PROMOTION_BUY_MONTH_YEAR> PROMOTION_BUY_MONTH_YEAR { get; set; }
        public DbSet<PROMOTION_GET> PROMOTION_GET { get; set; }
        public DbSet<PROMOTION_HISTORY> PROMOTION_HISTORY { get; set; }
        public DbSet<PROMOTION_STORE> PROMOTION_STORE { get; set; }
        public DbSet<PROMOTION_TIME> PROMOTION_TIME { get; set; }
        public DbSet<PromotionCustomerTag> PromotionCustomerTag { get; set; }
        public DbSet<PURCHASE_ORDER> PURCHASE_ORDER { get; set; }
        public DbSet<PURCHASE_ORDER_DETAILS> PURCHASE_ORDER_DETAILS { get; set; }
        public DbSet<PURCHASE_ORDER_DETAILS_WRK> PURCHASE_ORDER_DETAILS_WRK { get; set; }
        public DbSet<PURCHASE_RCV_DETAILS> PURCHASE_RCV_DETAILS { get; set; }
        public DbSet<PURCHASE_RCV_DETAILS_WRK> PURCHASE_RCV_DETAILS_WRK { get; set; }
        public DbSet<PURCHASE_RECEIVE> PURCHASE_RECEIVE { get; set; }
        public DbSet<PURCHASE_RETURN> PURCHASE_RETURN { get; set; }
        public DbSet<PURCHASE_RETURN_DETAILS> PURCHASE_RETURN_DETAILS { get; set; }
        public DbSet<PURCHASE_RETURN_DETAILS_WRK> PURCHASE_RETURN_DETAILS_WRK { get; set; }
        public DbSet<PurchaseGL> PurchaseGL { get; set; }
        public DbSet<PurchaseOrderGL> PurchaseOrderGL { get; set; }
        public DbSet<PurchaseOrderGLLog> PurchaseOrderGLLog { get; set; }
        public DbSet<REASON> REASON { get; set; }
        public DbSet<REJ_STORE_DELIVERY_DETAILS> REJ_STORE_DELIVERY_DETAILS { get; set; }
        public DbSet<ReOrderSetup> ReOrderSetup { get; set; }
        public DbSet<ReportHead> ReportHead { get; set; }
        public DbSet<ReportLog> ReportLog { get; set; }
        public DbSet<ReportSection> ReportSection { get; set; }
        public DbSet<ROLE> ROLE { get; set; }
        public DbSet<ROLE_MENU> ROLE_MENU { get; set; }
        public DbSet<SALE> SALE { get; set; }
        public DbSet<SALE_ORDER> SALE_ORDER { get; set; }
        public DbSet<SALE_ORDER_DETAILS> SALE_ORDER_DETAILS { get; set; }
        public DbSet<SALE_PAYMENT> SALE_PAYMENT { get; set; }
        public DbSet<SALE_PAYMENT_HIS> SALE_PAYMENT_HIS { get; set; }
        public DbSet<Sale_wrk> Sale_wrk { get; set; }
        public DbSet<SalePayment_His> SalePayment_His { get; set; }
        public DbSet<SalePayment_wrk> SalePayment_wrk { get; set; }
        public DbSet<ShopList> ShopList { get; set; }
        public DbSet<SmsGateway> SmsGateway { get; set; }
        public DbSet<SmsHistory> SmsHistory { get; set; }
        public DbSet<SmsTemplate> SmsTemplate { get; set; }
        public DbSet<SSUMMARY> SSUMMARY { get; set; }
        public DbSet<STORE> STORE { get; set; }
        public DbSet<STORE_ALLOCATION> STORE_ALLOCATION { get; set; }
        public DbSet<STORE_ALLOCATION_SETUP> STORE_ALLOCATION_SETUP { get; set; }
        public DbSet<STORE_ALLOCATION_WRK> STORE_ALLOCATION_WRK { get; set; }
        public DbSet<STORE_BRAND> STORE_BRAND { get; set; }
        public DbSet<STORE_DAMAGE_DELIVERY_RECEIVE> STORE_DAMAGE_DELIVERY_RECEIVE { get; set; }
        public DbSet<STORE_DELIVERY> STORE_DELIVERY { get; set; }
        public DbSet<STORE_DELIVERY_DETAILS> STORE_DELIVERY_DETAILS { get; set; }
        public DbSet<STORE_DELIVERY_DETAILS_DISCP_LOG> STORE_DELIVERY_DETAILS_DISCP_LOG { get; set; }
        public DbSet<STORE_DELIVERY_REGISTER> STORE_DELIVERY_REGISTER { get; set; }
        public DbSet<STORE_DML> STORE_DML { get; set; }
        public DbSet<STORE_DML_CUSTOMER_WISE> STORE_DML_CUSTOMER_WISE { get; set; }
        public DbSet<STORE_PRODUCT_BARCODE> STORE_PRODUCT_BARCODE { get; set; }
        public DbSet<STORE_REQUISITION> STORE_REQUISITION { get; set; }
        public DbSet<STORE_REQUISITION_WRK> STORE_REQUISITION_WRK { get; set; }
        public DbSet<STORE_SUPERVISOR> STORE_SUPERVISOR { get; set; }
        public DbSet<STORE_TRANSFER_PERMISSION> STORE_TRANSFER_PERMISSION { get; set; }
        public DbSet<StoreDelivery_Wrk> StoreDelivery_Wrk { get; set; }
        public DbSet<StoreDeliveryDetails_wrk> StoreDeliveryDetails_wrk { get; set; }
        public DbSet<STOREDELIVERYRECEIVE> STOREDELIVERYRECEIVE { get; set; }
        public DbSet<StoreDML_wrk> StoreDML_wrk { get; set; }
        public DbSet<StoreDML_wrkCustomerWise> StoreDML_wrkCustomerWise { get; set; }
        public DbSet<StoreLogo> StoreLogo { get; set; }
        public DbSet<StoreMetaData> StoreMetaData { get; set; }
        public DbSet<StoreMetaDataRubel> StoreMetaDataRubel { get; set; }
        public DbSet<StoreNotification> StoreNotification { get; set; }
        public DbSet<StoreSetup> StoreSetup { get; set; }
        public DbSet<StoreWiseMinimumQtyDel> StoreWiseMinimumQtyDel { get; set; }
        public DbSet<SUB_CATEGORY> SUB_CATEGORY { get; set; }
        public DbSet<SUB_CATEGORY_Log> SUB_CATEGORY_Log { get; set; }
        public DbSet<SUB_SUBCATEGORY> SUB_SUBCATEGORY { get; set; }
        public DbSet<SUB_SUBCATEGORY_Log> SUB_SUBCATEGORY_Log { get; set; }
        public DbSet<SUB_SUBCATEGORY_VARIANCE> SUB_SUBCATEGORY_VARIANCE { get; set; }
        public DbSet<SUB_SUBCATEGORY_VARIANCE_VALUE> SUB_SUBCATEGORY_VARIANCE_VALUE { get; set; }
        public DbSet<SUBCATEGORY_VARIANCE> SUBCATEGORY_VARIANCE { get; set; }
        public DbSet<SubDepartment> SubDepartment { get; set; }
        public DbSet<SubDepartment_Log> SubDepartment_Log { get; set; }
        public DbSet<SubSubcategory> SubSubcategory { get; set; }
        public DbSet<Temp_BillEntry> Temp_BillEntry { get; set; }
        public DbSet<Temp_BillPayment> Temp_BillPayment { get; set; }
        public DbSet<TEMP_CIRCULAR_DISCOUNT> TEMP_CIRCULAR_DISCOUNT { get; set; }
        public DbSet<TEMP_CUSTOMER_QUOTATION> TEMP_CUSTOMER_QUOTATION { get; set; }
        public DbSet<Temp_GLHO> Temp_GLHO { get; set; }
        public DbSet<ThirdPartySalePostingLog> ThirdPartySalePostingLog { get; set; }
        public DbSet<UpdateRemove_Log> UpdateRemove_Log { get; set; }
        public DbSet<UsedDiscounts> UsedDiscounts { get; set; }
        public DbSet<USER_MENU> USER_MENU { get; set; }
        public DbSet<USER_PRICE_PERMISSION> USER_PRICE_PERMISSION { get; set; }
        public DbSet<USER_PRICE_SHOW_PERMISSION> USER_PRICE_SHOW_PERMISSION { get; set; }
        public DbSet<UserMenuDistribution> UserMenuDistribution { get; set; }
        public DbSet<USERS> USERS { get; set; }
        public DbSet<VARIANCE_ATTRIBUTE> VARIANCE_ATTRIBUTE { get; set; }
        public DbSet<VatIntegration> VatIntegration { get; set; }
        public DbSet<VEHICLE> VEHICLE { get; set; }
        public DbSet<VENDOR> VENDOR { get; set; }
        public DbSet<VENDOR_ADDITIONAL_INFO> VENDOR_ADDITIONAL_INFO { get; set; }
        public DbSet<VENDOR_CONTACT> VENDOR_CONTACT { get; set; }
        public DbSet<VENDOR_Log> VENDOR_Log { get; set; }
        public DbSet<VENDOR_REGISTRATION_INFO> VENDOR_REGISTRATION_INFO { get; set; }
        public DbSet<VIRTUAL_STORE_INVENTORY> VIRTUAL_STORE_INVENTORY { get; set; }
        public DbSet<WeighingScaleSetup> WeighingScaleSetup { get; set; }
        public DbSet<WorkOrderGL> WorkOrderGL { get; set; }
        public DbSet<WorkOrderGLLog> WorkOrderGLLog { get; set; }
        public DbSet<WORKSTATION> WORKSTATION { get; set; }
        public DbSet<GetTempSaleQueryResult> GetTempSaleQueryResult { get; set; }



    }
}
