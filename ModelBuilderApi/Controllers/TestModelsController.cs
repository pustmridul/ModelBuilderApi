using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ModelBuilderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestModelsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public TestModelsController(AppDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //[Route("GetAgeRange")]
        //public async Task<IActionResult> GetAgeRange()
        //{
        //    try
        //    {
        //        var result = await _context.AgeRanges.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("GetAppUser")]
        //public async Task<IActionResult> GetAppUser()
        //{
        //    try
        //    {
        //        var result = await _context.App_Users.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("GetArea")]
        //public async Task<IActionResult> GetArea()
        //{
        //    try
        //    {
        //        var result = await _context.AREAS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("GetBarcodePrintLog")]
        //public async Task<IActionResult> GetBarcodePrintLog()
        //{
        //    try
        //    {
        //        var result = await _context.BarcodePrintLogs.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("BookingPayment")]
        //public async Task<IActionResult> GetBookingPayment()
        //{
        //    try
        //    {
        //        var result = await _context.BookingPayments.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("BookingSummary")]
        //public async Task<IActionResult> GetBookingSummary()
        //{
        //    try
        //    {
        //        var result = await _context.BookingSummarys.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("BRAND")]
        //public async Task<IActionResult> GetBRAND()
        //{
        //    try
        //    {
        //        var result = await _context.BRANDS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("BRAND_Log")]
        //public async Task<IActionResult> GetBRAND_Log()
        //{
        //    try
        //    {
        //        var result = await _context.BRAND_Logs.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("CancelReason")]
        //public async Task<IActionResult> GetCancelReason()
        //{
        //    try
        //    {
        //        var result = await _context.CancelReasons.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("CardType")]
        //public async Task<IActionResult> GetCard_Type()
        //{
        //    try
        //    {
        //        var result = await _context.CardTypes.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("CIRCULAR_PRICE_CHANGE")]
        //public async Task<IActionResult> GetCIRCULAR_PRICE_CHANGE()
        //{
        //    try
        //    {
        //        var result = await _context.CIRCULAR_PRICE_CHANGES.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("CITY")]
        //public async Task<IActionResult> GetCITY()
        //{
        //    try
        //    {
        //        var result = await _context.CITYS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("CLAIM_REASON")]
        //public async Task<IActionResult> GetCLAIM_REASON()
        //{
        //    try
        //    {
        //        var result = await _context.CLAIM_REASONS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("COMPANY_INFO")]
        //public async Task<IActionResult> GetCOMPANY_INFO()
        //{
        //    try
        //    {
        //        var result = await _context.COMPANY_INFOS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("ConsoleSetup")]
        //public async Task<IActionResult> GetConsoleSetup()
        //{
        //    try
        //    {
        //        var result = await _context.ConsoleSetups.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("ConsoleType")]
        //public async Task<IActionResult> GetConsoleType()
        //{
        //    try
        //    {
        //        var result = await _context.ConsoleTypes.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("COURIER_LOG")]
        //public async Task<IActionResult> GetCOURIER_LOG()
        //{
        //    try
        //    {
        //        var result = await _context.COURIER_LOGS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("CourierChargeRule")]
        //public async Task<IActionResult> GetCourierChargeRule()
        //{
        //    try
        //    {
        //        var result = await _context.CourierChargeRules.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("CourierLocation")]
        //public async Task<IActionResult> GetCourierLocation()
        //{
        //    try
        //    {
        //        var result = await _context.CourierLocations.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("CourierService")]
        //public async Task<IActionResult> GetCourierService()
        //{
        //    try
        //    {
        //        var result = await _context.CourierServices.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("cProfile")]
        //public async Task<IActionResult> GetcProfile()
        //{
        //    try
        //    {
        //        var result = await _context.cProfiles.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("CREDIT_COLLECTION")]
        //public async Task<IActionResult> GetCREDIT_COLLECTION()
        //{
        //    try
        //    {
        //        var result = await _context.CREDIT_COLLECTIONS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("CREDIT_NOTE")]
        //public async Task<IActionResult> GetCREDIT_NOTE()
        //{
        //    try
        //    {
        //        var result = await _context.CREDIT_NOTES.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("CUSTOMER")]
        //public async Task<IActionResult> GetCUSTOMER()
        //{
        //    try
        //    {
        //        var result = await _context.CUSTOMERS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("CUSTOMER_BARCODE")]
        //public async Task<IActionResult> GetCUSTOMER_BARCODE()
        //{
        //    try
        //    {
        //        var result = await _context.CUSTOMER_BARCODES.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("CUSTOMER_CARD")]
        //public async Task<IActionResult> GetCUSTOMER_CARD()
        //{
        //    try
        //    {
        //        var result = await _context.CUSTOMER_CARDS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("CUSTOMER_CREDIT_LEDGER")]
        //public async Task<IActionResult> GetCUSTOMER_CREDIT_LEDGER()
        //{
        //    try
        //    {
        //        var result = await _context.CUSTOMER_CREDIT_LEDGERS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("CUSTOMER_Log")]
        //public async Task<IActionResult> GetCUSTOMER_Log()
        //{
        //    try
        //    {
        //        var result = await _context.CUSTOMER_Logs.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("CUSTOMER_PRICE_SETUP")]
        //public async Task<IActionResult> GetCUSTOMER_PRICE_SETUP()
        //{
        //    try
        //    {
        //        var result = await _context.CUSTOMER_PRICE_SETUPS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("CUSTOMER_QUOTATION")]
        //public async Task<IActionResult> GetCUSTOMER_QUOTATION()
        //{
        //    try
        //    {
        //        var result = await _context.CUSTOMER_QUOTATIONS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("CustomerExtraField")]
        //public async Task<IActionResult> GetCustomerExtraField()
        //{
        //    try
        //    {
        //        var result = await _context.CustomerExtraFields.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("CustomerType")]
        //public async Task<IActionResult> GetCustomerType()
        //{
        //    try
        //    {
        //        var result = await _context.CustomerTypes.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("CustomerType_Log")]
        //public async Task<IActionResult> GetCustomerType_Log()
        //{
        //    try
        //    {
        //        var result = await _context.CustomerType_Logs.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("CustomerUpgradationDegradation")]
        //public async Task<IActionResult> GetCustomerUpgradationDegradation()
        //{
        //    try
        //    {
        //        var result = await _context.CustomerUpgradationDegradations.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PRODUCT")]
        //public async Task<IActionResult> GetPRODUCT()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCTS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("CustomerVoucher")]
        //public async Task<IActionResult> GetCustomerVoucher()
        //{
        //    try
        //    {
        //        var result = await _context.CustomerVouchers.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("CustomSmsHistory")]
        //public async Task<IActionResult> GetCustomSmsHistory()
        //{
        //    try
        //    {
        //        var result = await _context.CustomSmsHistorys.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("DayCloseLog")]
        //public async Task<IActionResult> GetDayCloseLog()
        //{
        //    try
        //    {
        //        var result = await _context.DayCloseLogs.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("DELIVERY_REQUISITION")]
        //public async Task<IActionResult> GetDELIVERY_REQUISITION()
        //{
        //    try
        //    {
        //        var result = await _context.DELIVERY_REQUISITIONS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("DeliveryPerson")]
        //public async Task<IActionResult> GetDeliveryPerson()
        //{
        //    try
        //    {
        //        var result = await _context.DeliveryPersons.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("Department")]
        //public async Task<IActionResult> GetDepartment()
        //{
        //    try
        //    {
        //        var result = await _context.Departments.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("Department_Log")]
        //public async Task<IActionResult> GetDepartment_Log()
        //{
        //    try
        //    {
        //        var result = await _context.Department_Logs.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("DESIRED_STOCK_SETUP")]
        //public async Task<IActionResult> GetDESIRED_STOCK_SETUP()
        //{
        //    try
        //    {
        //        var result = await _context.DESIRED_STOCK_SETUPS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("BookingDetails")]
        //public async Task<IActionResult> GetBookingDetails()
        //{
        //    try
        //    {
        //        var result = await _context.BookingDetails.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("DISCOUNT_BRAND")]
        //public async Task<IActionResult> GetDISCOUNT_BRAND()
        //{
        //    try
        //    {
        //        var result = await _context.DISCOUNT_BRANDS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("DISCOUNT_NONBRAND")]
        //public async Task<IActionResult> GetDISCOUNT_NONBRAND()
        //{
        //    try
        //    {
        //        var result = await _context.DISCOUNT_NONBRANDS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("DO_Company")]
        //public async Task<IActionResult> GetDO_Company()
        //{
        //    try
        //    {
        //        var result = await _context.DO_Companys.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("DocPrintLog")]
        //public async Task<IActionResult> GetDocPrintLog()
        //{
        //    try
        //    {
        //        var result = await _context.DocPrintLogs.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("DONOR")]
        //public async Task<IActionResult> GetDONOR()
        //{
        //    try
        //    {
        //        var result = await _context.DONORS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("EcomExtraFieldSetup")]
        //public async Task<IActionResult> GetEcomExtraFieldSetup()
        //{
        //    try
        //    {
        //        var result = await _context.EcomExtraFieldSetups.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("EcomMessage")]
        //public async Task<IActionResult> GetEcomMessage()
        //{
        //    try
        //    {
        //        var result = await _context.EcomMessages.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("EMPLOYEE")]
        //public async Task<IActionResult> GetEMPLOYEE()
        //{
        //    try
        //    {
        //        var result = await _context.EMPLOYEES.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("EMPLOYEE_DESIGNATION")]
        //public async Task<IActionResult> GetEMPLOYEE_DESIGNATION()
        //{
        //    try
        //    {
        //        var result = await _context.EMPLOYEE_DESIGNATIONS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("EMPLOYEE_DESIGNATION_Log")]
        //public async Task<IActionResult> GetEMPLOYEE_DESIGNATION_Log()
        //{
        //    try
        //    {
        //        var result = await _context.EMPLOYEE_DESIGNATION_Logs.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("EmployeeAttachedStore")]
        //public async Task<IActionResult> GetEmployeeAttachedStore()
        //{
        //    try
        //    {
        //        var result = await _context.EmployeeAttachedStores.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("ExcessCreditLimit")]
        //public async Task<IActionResult> GetExcessCreditLimit()
        //{
        //    try
        //    {
        //        var result = await _context.ExcessCreditLimits.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("FreeTextName")]
        //public async Task<IActionResult> GetFreeTextName()
        //{
        //    try
        //    {
        //        var result = await _context.FreeTextNames.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("GIFT_ITEM_STOCK")]
        //public async Task<IActionResult> GetGIFT_ITEM_STOCK()
        //{
        //    try
        //    {
        //        var result = await _context.GIFT_ITEM_STOCK.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("GIFT_VOUCHER_GENERATION")]
        //public async Task<IActionResult> GetGIFT_VOUCHER_GENERATION()
        //{
        //    try
        //    {
        //        var result = await _context.GIFT_VOUCHER_GENERATION.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("GIFT_VOUCHER_GENERATION_LOG")]
        //public async Task<IActionResult> GetGIFT_VOUCHER_GENERATION_LOG()
        //{
        //    try
        //    {
        //        var result = await _context.GIFT_VOUCHER_GENERATION_LOGS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("GIFT_VOUCHER_STOCK")]
        //public async Task<IActionResult> GetGIFT_VOUCHER_STOCK()
        //{
        //    try
        //    {
        //        var result = await _context.GIFT_VOUCHER_STOCKS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("GiftVoucherDelivery")]
        //public async Task<IActionResult> GetGiftVoucherDelivery()
        //{
        //    try
        //    {
        //        var result = await _context.GiftVoucherDeliverys.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("GiftVoucherDeliveryDetails")]
        //public async Task<IActionResult> GetGiftVoucherDeliveryDetails()
        //{
        //    try
        //    {
        //        var result = await _context.GiftVoucherDeliveryDetails.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("GlobalSetupGL")]
        //public async Task<IActionResult> GetGlobalSetupGL()
        //{
        //    try
        //    {
        //        var result = await _context.GlobalSetupGL.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("GLSTRUCTURE")]
        //public async Task<IActionResult> GetGLSTRUCTURE()
        //{
        //    try
        //    {
        //        var result = await _context.GLSTRUCTURE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("INVALID_PRODUCT_SALE_REGISTER")]
        //public async Task<IActionResult> GetINVALID_PRODUCT_SALE_REGISTER()
        //{
        //    try
        //    {
        //        var result = await _context.INVALID_PRODUCT_SALE_REGISTER.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("INVOICE_CREDIT_LEDGER")]
        //public async Task<IActionResult> GetINVOICE_CREDIT_LEDGER()
        //{
        //    try
        //    {
        //        var result = await _context.INVOICE_CREDIT_LEDGER.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("InvoiceDelivery")]
        //public async Task<IActionResult> GetInvoiceDelivery()
        //{
        //    try
        //    {
        //        var result = await _context.InvoiceDelivery.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("InvTrackingAuditorDetails")]
        //public async Task<IActionResult> GetInvTrackingAuditorDetails()
        //{
        //    try
        //    {
        //        var result = await _context.InvTrackingAuditorDetails.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("InvTrackingDetails")]
        //public async Task<IActionResult> GetInvTrackingDetails()
        //{
        //    try
        //    {
        //        var result = await _context.InvTrackingDetails.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("InvTrackingDetailsUpdate")]
        //public async Task<IActionResult> GetInvTrackingDetailsUpdate()
        //{
        //    try
        //    {
        //        var result = await _context.InvTrackingDetailsUpdates.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("InvTrackingSummary")]
        //public async Task<IActionResult> GetInvTrackingSummary()
        //{
        //    try
        //    {
        //        var result = await _context.InvTrackingSummary.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("InvTrackingSummaryTemp")]
        //public async Task<IActionResult> GetInvTrackingSummaryTemp()
        //{
        //    try
        //    {
        //        var result = await _context.InvTrackingSummaryTemp.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("LabelSetup")]
        //public async Task<IActionResult> GetLabelSetup()
        //{
        //    try
        //    {
        //        var result = await _context.LabelSetup.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("LoginLog")]
        //public async Task<IActionResult> GetLoginLog()
        //{
        //    try
        //    {
        //        var result = await _context.LoginLog.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("LoyaltyPointsHistory")]
        //public async Task<IActionResult> GetLoyaltyPointsHistory()
        //{
        //    try
        //    {
        //        var result = await _context.LoyaltyPointsHistory.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("MANUFACTURER")]
        //public async Task<IActionResult> GetMANUFACTURER()
        //{
        //    try
        //    {
        //        var result = await _context.MANUFACTURER.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("MEASURING_UNIT")]
        //public async Task<IActionResult> GetMEASURING_UNIT()
        //{
        //    try
        //    {
        //        var result = await _context.MEASURING_UNIT.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("MEASURING_UNIT_Log")]
        //public async Task<IActionResult> GetMEASURING_UNIT_Log()
        //{
        //    try
        //    {
        //        var result = await _context.MEASURING_UNIT_Log.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("MEMBER_POINT_PROMOTION")]
        //public async Task<IActionResult> GetMEMBER_POINT_PROMOTION()
        //{
        //    try
        //    {
        //        var result = await _context.MEMBER_POINT_PROMOTION.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("MENU")]
        //public async Task<IActionResult> GetMENU()
        //{
        //    try
        //    {
        //        var result = await _context.MENU.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("MenuA")]
        //public async Task<IActionResult> GetMenuA()
        //{
        //    try
        //    {
        //        var result = await _context.MenuA.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("Notification")]
        //public async Task<IActionResult> GetNotification()
        //{
        //    try
        //    {
        //        var result = await _context.Notification.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("ORDER")]
        //public async Task<IActionResult> GetORDER()
        //{
        //    try
        //    {
        //        var result = await _context.ORDERS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("ORDER_ADDRESS")]
        //public async Task<IActionResult> GetORDER_ADDRESS()
        //{
        //    try
        //    {
        //        var result = await _context.ORDER_ADDRESS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("ORDER_ADDRESS_EDIT_HIS")]
        //public async Task<IActionResult> GetORDER_ADDRESS_EDIT_HIS()
        //{
        //    try
        //    {
        //        var result = await _context.ORDER_ADDRESS_EDIT_HIS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("ORDER_DETAILS")]
        //public async Task<IActionResult> GetORDER_DETAILS()
        //{
        //    try
        //    {
        //        var result = await _context.ORDER_DETAILS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("ORDER_DETAILS_EDIT_HIS")]
        //public async Task<IActionResult> GetORDER_DETAILS_EDIT_HIS()
        //{
        //    try
        //    {
        //        var result = await _context.ORDER_DETAILS_EDIT_HIS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("ORDER_DETAILS_WRK")]
        //public async Task<IActionResult> GetORDER_DETAILS_WRK()
        //{
        //    try
        //    {
        //        var result = await _context.ORDER_DETAILS_WRK.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("ORDER_EDIT_HIS")]
        //public async Task<IActionResult> GetORDER_EDIT_HIS()
        //{
        //    try
        //    {
        //        var result = await _context.ORDER_EDIT_HIS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("ORDER_TRACKING")]
        //public async Task<IActionResult> GetORDER_TRACKING()
        //{
        //    try
        //    {
        //        var result = await _context.ORDER_TRACKING.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("OrderDeliveryScan")]
        //public async Task<IActionResult> GetOrderDeliveryScan()
        //{
        //    try
        //    {
        //        var result = await _context.OrderDeliveryScan.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("OrderLog")]
        //public async Task<IActionResult> GetOrderLog()
        //{
        //    try
        //    {
        //        var result = await _context.OrderLog.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("OrderNote")]
        //public async Task<IActionResult> GetOrderNote()
        //{
        //    try
        //    {
        //        var result = await _context.OrderNote.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("OtpHistory")]
        //public async Task<IActionResult> GetOtpHistory()
        //{
        //    try
        //    {
        //        var result = await _context.OtpHistory.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        [HttpGet]
        [Route("P_SALE")]
        public async Task<IActionResult> GetP_SALE()
        {
            try
            {
                var result = await _context.P_SALE.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }

        [HttpGet]
        [Route("P_SALE_PAYMENT")]
        public async Task<IActionResult> GetP_SALE_PAYMENT()
        {
            try
            {
                var result = await _context.P_SALE_PAYMENT.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }



        [HttpGet]
        [Route("P_SSUMMARY")]
        public async Task<IActionResult> GetP_SSUMMARY()
        {
            try
            {
                var result = await _context.P_SSUMMARY.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }


        [HttpGet]
        [Route("PACK_SIZE_LIST")]
        public async Task<IActionResult> GetPACK_SIZE_LIST()
        {
            try
            {
                var result = await _context.PACK_SIZE_LIST.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }


        [HttpGet]
        [Route("PACKAGE_BOOKING_REGISTER")]
        public async Task<IActionResult> GetPACKAGE_BOOKING_REGISTER()
        {
            try
            {
                var result = await _context.PACKAGE_BOOKING_REGISTER.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }

        [HttpGet]
        [Route("PACKAGE_SALE_REGISTER")]
        public async Task<IActionResult> GetPACKAGE_SALE_REGISTER()
        {
            try
            {
                var result = await _context.PACKAGE_SALE_REGISTER.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }

        [HttpGet]
        [Route("PAYMENT_METHOD")]
        public async Task<IActionResult> GetPAYMENT_METHOD()
        {
            try
            {
                var result = await _context.PAYMENT_METHOD.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet]
        [Route("PAYMENT_METHOD_Log")]
        public async Task<IActionResult> GetPAYMENT_METHOD_Log()
        {
            try
            {
                var result = await _context.PAYMENT_METHOD_Log.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }

        [HttpGet]
        [Route("PHYSICAL_PRODUCT_STOCK")]
        public async Task<IActionResult> GetPHYSICAL_PRODUCT_STOCK()
        {
            try
            {
                var result = await _context.PHYSICAL_PRODUCT_STOCK.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }



        [HttpGet]
        [Route("PLNoteSetup")]
        public async Task<IActionResult> GePLNoteSetup()
        {
            try
            {
                var result = await _context.PLNoteSetup.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }



    }
}
