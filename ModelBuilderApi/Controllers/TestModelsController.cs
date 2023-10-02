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



        //[HttpGet]
        //[Route("P_SALE")]
        //public async Task<IActionResult> GetP_SALE()
        //{
        //    try
        //    {
        //        var result = await _context.P_SALE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("P_SALE_PAYMENT")]
        //public async Task<IActionResult> GetP_SALE_PAYMENT()
        //{
        //    try
        //    {
        //        var result = await _context.P_SALE_PAYMENT.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("P_SSUMMARY")]
        //public async Task<IActionResult> GetP_SSUMMARY()
        //{
        //    try
        //    {
        //        var result = await _context.P_SSUMMARY.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PACK_SIZE_LIST")]
        //public async Task<IActionResult> GetPACK_SIZE_LIST()
        //{
        //    try
        //    {
        //        var result = await _context.PACK_SIZE_LIST.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PACKAGE_BOOKING_REGISTER")]
        //public async Task<IActionResult> GetPACKAGE_BOOKING_REGISTER()
        //{
        //    try
        //    {
        //        var result = await _context.PACKAGE_BOOKING_REGISTER.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PACKAGE_SALE_REGISTER")]
        //public async Task<IActionResult> GetPACKAGE_SALE_REGISTER()
        //{
        //    try
        //    {
        //        var result = await _context.PACKAGE_SALE_REGISTER.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PAYMENT_METHOD")]
        //public async Task<IActionResult> GetPAYMENT_METHOD()
        //{
        //    try
        //    {
        //        var result = await _context.PAYMENT_METHOD.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("PAYMENT_METHOD_Log")]
        //public async Task<IActionResult> GetPAYMENT_METHOD_Log()
        //{
        //    try
        //    {
        //        var result = await _context.PAYMENT_METHOD_Log.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PHYSICAL_PRODUCT_STOCK")]
        //public async Task<IActionResult> GetPHYSICAL_PRODUCT_STOCK()
        //{
        //    try
        //    {
        //        var result = await _context.PHYSICAL_PRODUCT_STOCK.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("PLNoteSetup")]
        //public async Task<IActionResult> GePLNoteSetup()
        //{
        //    try
        //    {
        //        var result = await _context.PLNoteSetup.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PointEarnPolicy")]
        //public async Task<IActionResult> GePointEarnPolicy()
        //{
        //    try
        //    {
        //        var result = await _context.PointEarnPolicy.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PreGL")]
        //public async Task<IActionResult> GePreGL()
        //{
        //    try
        //    {
        //        var result = await _context.PreGL.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PREGLStructure")]
        //public async Task<IActionResult> GePREGLStructure()
        //{
        //    try
        //    {
        //        var result = await _context.PREGLStructure.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PRIORITY")]
        //public async Task<IActionResult> GePRIORITY()
        //{
        //    try
        //    {
        //        var result = await _context.PRIORITY.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("ProcessedInvoice")]
        //public async Task<IActionResult> GeProcessedInvoice()
        //{
        //    try
        //    {
        //        var result = await _context.ProcessedInvoice.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("PRODUCT_ALLOCATION_RATIO")]
        //public async Task<IActionResult> GePRODUCT_ALLOCATION_RATIO()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_ALLOCATION_RATIO.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PRODUCT_ATTRIBUTE")]
        //public async Task<IActionResult> GetPRODUCT_ATTRIBUTE()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_ATTRIBUTE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PRODUCT_BARCODE")]
        //public async Task<IActionResult> GetPRODUCT_BARCODE()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_BARCODE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("PRODUCT_BOM")]
        //public async Task<IActionResult> GetPRODUCT_BOM()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_BOM.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PRODUCT_CARTON")]
        //public async Task<IActionResult> GetPRODUCT_CARTON()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_CARTON.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PRODUCT_CONVERSION")]
        //public async Task<IActionResult> GetPRODUCT_CONVERSION()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_CONVERSION.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PRODUCT_CONVERSION_SUMMARY")]
        //public async Task<IActionResult> GetPRODUCT_CONVERSION_SUMMARY()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_CONVERSION_SUMMARY.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("PRODUCT_CONVERTION_SETUP")]
        //public async Task<IActionResult> GetPRODUCT_CONVERTION_SETUP()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_CONVERTION_SETUP.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PRODUCT_DELETE_LOG")]
        //public async Task<IActionResult> GetPRODUCT_DELETE_LOG()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_DELETE_LOG.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("PRODUCT_FILE")]
        //public async Task<IActionResult> GetPRODUCT_FILE()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_FILE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("Product_FileRubel")]
        //public async Task<IActionResult> GetProduct_FileRubel()
        //{
        //    try
        //    {
        //        var result = await _context.Product_FileRubel.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PRODUCT_HIS")]
        //public async Task<IActionResult> GetPRODUCT_HIS()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_HIS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PRODUCT_OPTIONS")]
        //public async Task<IActionResult> GetPRODUCT_OPTIONS()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_OPTIONS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PRODUCT_STOCK")]
        //public async Task<IActionResult> GetPRODUCT_STOCK()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_STOCK.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PRODUCT_STOCK23AUG2022")]
        //public async Task<IActionResult> GetPRODUCT_STOCK23AUG2022()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_STOCK23AUG2022.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PRODUCT_VARIANCE")]
        //public async Task<IActionResult> GetPRODUCT_VARIANCE()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_VARIANCE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PRODUCT_VARIANCE_SEQUENCE")]
        //public async Task<IActionResult> GetPRODUCT_VARIANCE_SEQUENCE()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_VARIANCE_SEQUENCE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("PRODUCT_VENDOR")]
        //public async Task<IActionResult> GET_PRODUCT_VENDOR()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_VENDOR.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PRODUCT_VENDOR_USER_BARCODE")]
        //public async Task<IActionResult> GET_PRODUCT_VENDOR_USER_BARCODE()
        //{
        //    try
        //    {
        //        var result = await _context.PRODUCT_VENDOR_USER_BARCODE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("ProductColumnDefine")]
        //public async Task<IActionResult> GET_ProductColumnDefine()
        //{
        //    try
        //    {
        //        var result = await _context.ProductColumnDefine.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}




        //[HttpGet]
        //[Route("ProductConversionWrk")]
        //public async Task<IActionResult> GET_ProductConversionWrk()
        //{
        //    try
        //    {
        //        var result = await _context.ProductConversionWrk.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("ProductExtraFieldSetup")]
        //public async Task<IActionResult> GET_ProductExtraFieldSetup()
        //{
        //    try
        //    {
        //        var result = await _context.ProductExtraFieldSetup.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("Production")]
        //public async Task<IActionResult> GET_Production()
        //{
        //    try
        //    {
        //        var result = await _context.Production.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("ProductionIng")]
        //public async Task<IActionResult> GET_ProductionIng()
        //{
        //    try
        //    {
        //        var result = await _context.ProductionIng.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("ProductPeriodicalBarcodewiseData")]
        //public async Task<IActionResult> GET_ProductPeriodicalBarcodewiseData()
        //{
        //    try
        //    {
        //        var result = await _context.ProductPeriodicalBarcodewiseData.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("ProductPeriodicalBarcodewiseDataLog")]
        //public async Task<IActionResult> GET_ProductPeriodicalBarcodewiseDataLog()
        //{
        //    try
        //    {
        //        var result = await _context.ProductPeriodicalBarcodewiseDataLog.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("ProductRubel")]
        //public async Task<IActionResult> GET_ProductRubel()
        //{
        //    try
        //    {
        //        var result = await _context.ProductRubel.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PROMOTION")]
        //public async Task<IActionResult> GET_PROMOTION()
        //{
        //    try
        //    {
        //        var result = await _context.PROMOTION.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PROMOTION_BUY")]
        //public async Task<IActionResult> GET_PROMOTION_BUY()
        //{
        //    try
        //    {
        //        var result = await _context.PROMOTION_BUY.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PROMOTION_BUY_MONTH_YEAR")]
        //public async Task<IActionResult> GET_PROMOTION_BUY_MONTH_YEAR()
        //{
        //    try
        //    {
        //        var result = await _context.PROMOTION_BUY_MONTH_YEAR.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PROMOTION_GET")]
        //public async Task<IActionResult> GET_PROMOTION_GET()
        //{
        //    try
        //    {
        //        var result = await _context.PROMOTION_GET.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("PROMOTION_HISTORY")]
        //public async Task<IActionResult> GET_PROMOTION_HISTORY()
        //{
        //    try
        //    {
        //        var result = await _context.PROMOTION_HISTORY.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PROMOTION_STORE")]
        //public async Task<IActionResult> GET_PROMOTION_STORE()
        //{
        //    try
        //    {
        //        var result = await _context.PROMOTION_STORE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PROMOTION_TIME")]
        //public async Task<IActionResult> GET_PROMOTION_TIME()
        //{
        //    try
        //    {
        //        var result = await _context.PROMOTION_TIME.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PromotionCustomerTag")]
        //public async Task<IActionResult> GET_PromotionCustomerTag()
        //{
        //    try
        //    {
        //        var result = await _context.PromotionCustomerTag.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PURCHASE_ORDER")]
        //public async Task<IActionResult> GET_PURCHASE_ORDER()
        //{
        //    try
        //    {
        //        var result = await _context.PURCHASE_ORDER.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PURCHASE_ORDER_DETAILS")]
        //public async Task<IActionResult> GET_PURCHASE_ORDER_DETAILS()
        //{
        //    try
        //    {
        //        var result = await _context.PURCHASE_ORDER_DETAILS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PURCHASE_ORDER_DETAILS_WRK")]
        //public async Task<IActionResult> GET_PURCHASE_ORDER_DETAILS_WRK()
        //{
        //    try
        //    {
        //        var result = await _context.PURCHASE_ORDER_DETAILS_WRK.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PURCHASE_RCV_DETAILS")]
        //public async Task<IActionResult> GET_PURCHASE_RCV_DETAILS()
        //{
        //    try
        //    {
        //        var result = await _context.PURCHASE_RCV_DETAILS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("PURCHASE_RCV_DETAILS_WRK")]
        //public async Task<IActionResult> GET_PURCHASE_RCV_DETAILS_WRK()
        //{
        //    try
        //    {
        //        var result = await _context.PURCHASE_RCV_DETAILS_WRK.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PURCHASE_RECEIVE")]
        //public async Task<IActionResult> GET_PURCHASE_RECEIVE()
        //{
        //    try
        //    {
        //        var result = await _context.PURCHASE_RECEIVE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PURCHASE_RETURN")]
        //public async Task<IActionResult> GETPURCHASE_RETURN()
        //{
        //    try
        //    {
        //        var result = await _context.PURCHASE_RETURN.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PURCHASE_RETURN_DETAILS")]
        //public async Task<IActionResult> GEPURCHASE_RETURN_DETAILS()
        //{
        //    try
        //    {
        //        var result = await _context.PURCHASE_RETURN_DETAILS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("PURCHASE_RETURN_DETAILS_WRK")]
        //public async Task<IActionResult> GE_PURCHASE_RETURN_DETAILS_WRK()
        //{
        //    try
        //    {
        //        var result = await _context.PURCHASE_RETURN_DETAILS_WRK.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("PurchaseGL")]
        //public async Task<IActionResult> GE_PurchaseGL()
        //{
        //    try
        //    {
        //        var result = await _context.PurchaseGL.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PurchaseOrderGL")]
        //public async Task<IActionResult> GE_PurchaseOrderGL()
        //{
        //    try
        //    {
        //        var result = await _context.PurchaseOrderGL.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("PurchaseOrderGLLog")]
        //public async Task<IActionResult> GE_PurchaseOrderGLLog()
        //{
        //    try
        //    {
        //        var result = await _context.PurchaseOrderGLLog.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("REASON")]
        //public async Task<IActionResult> GE_REASON()
        //{
        //    try
        //    {
        //        var result = await _context.REASON.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("REJ_STORE_DELIVERY_DETAILS")]
        //public async Task<IActionResult> GE_REJ_STORE_DELIVERY_DETAILS()
        //{
        //    try
        //    {
        //        var result = await _context.REJ_STORE_DELIVERY_DETAILS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}




        //[HttpGet]
        //[Route("ReOrderSetup")]
        //public async Task<IActionResult> GE_ReOrderSetup()
        //{
        //    try
        //    {
        //        var result = await _context.ReOrderSetup.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("ReportHead")]
        //public async Task<IActionResult> GE_ReportHead()
        //{
        //    try
        //    {
        //        var result = await _context.ReportHead.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("ReportLog")]
        //public async Task<IActionResult> GE_ReportLog()
        //{
        //    try
        //    {
        //        var result = await _context.ReportLog.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}




        //[HttpGet]
        //[Route("ReportSection")]
        //public async Task<IActionResult> GE_ReportSection()
        //{
        //    try
        //    {
        //        var result = await _context.ReportSection.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("ROLE")]
        //public async Task<IActionResult> GE_ROLE()
        //{
        //    try
        //    {
        //        var result = await _context.ROLE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("ROLE_MENU")]
        //public async Task<IActionResult> GE_ROLE_MENU()
        //{
        //    try
        //    {
        //        var result = await _context.ROLE_MENU.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("SALE")]
        //public async Task<IActionResult> GE_SALE()
        //{
        //    try
        //    {
        //        var result = await _context.SALE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}




        //[HttpGet]
        //[Route("SALE_ORDER")]
        //public async Task<IActionResult> GE_SALE_ORDER()
        //{
        //    try
        //    {
        //        var result = await _context.SALE_ORDER.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("SALE_ORDER_DETAILS")]
        //public async Task<IActionResult> GE_SALE_ORDER_DETAILS()
        //{
        //    try
        //    {
        //        var result = await _context.SALE_ORDER_DETAILS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("SALE_PAYMENT")]
        //public async Task<IActionResult> GE_SALE_PAYMENT()
        //{
        //    try
        //    {
        //        var result = await _context.SALE_PAYMENT.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("SALE_PAYMENT_HIS")]
        //public async Task<IActionResult> GE_SALE_PAYMENT_HIS()
        //{
        //    try
        //    {
        //        var result = await _context.SALE_PAYMENT_HIS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}





        //[HttpGet]
        //[Route("Sale_wrk")]
        //public async Task<IActionResult> GE_Sale_wrk()
        //{
        //    try
        //    {
        //        var result = await _context.Sale_wrk.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("SalePayment_His")]
        //public async Task<IActionResult> GE_SalePayment_His()
        //{
        //    try
        //    {
        //        var result = await _context.SalePayment_His.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("SalePayment_wrk")]
        //public async Task<IActionResult> GE_SalePayment_wrk()
        //{
        //    try
        //    {
        //        var result = await _context.SalePayment_wrk.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("ShopList")]
        //public async Task<IActionResult> GE_ShopList()
        //{
        //    try
        //    {
        //        var result = await _context.ShopList.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("SmsGateway")]
        //public async Task<IActionResult> GE_SmsGateway()
        //{
        //    try
        //    {
        //        var result = await _context.SmsGateway.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("SmsHistory")]
        //public async Task<IActionResult> GE_SmsHistory()
        //{
        //    try
        //    {
        //        var result = await _context.SmsHistory.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("SmsTemplate")]
        //public async Task<IActionResult> GE_SmsTemplate()
        //{
        //    try
        //    {
        //        var result = await _context.SmsTemplate.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("SSUMMARY")]
        //public async Task<IActionResult> GE_SSUMMARY()
        //{
        //    try
        //    {
        //        var result = await _context.SSUMMARY.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("STORE")]
        //public async Task<IActionResult> GE_STORE()
        //{
        //    try
        //    {
        //        var result = await _context.STORE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("STORE_ALLOCATION")]
        //public async Task<IActionResult> GE_STORE_ALLOCATION()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_ALLOCATION.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("STORE_ALLOCATION_SETUP")]
        //public async Task<IActionResult> GE_STORE_ALLOCATION_SETUP()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_ALLOCATION_SETUP.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("STORE_ALLOCATION_WRK")]
        //public async Task<IActionResult> GE_STORE_ALLOCATION_WRK()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_ALLOCATION_WRK.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("STORE_BRAND")]
        //public async Task<IActionResult> GE_STORE_BRAND()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_BRAND.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("STORE_DAMAGE_DELIVERY_RECEIVE")]
        //public async Task<IActionResult> GE_STORE_DAMAGE_DELIVERY_RECEIVE()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_DAMAGE_DELIVERY_RECEIVE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("STORE_DELIVERY")]
        //public async Task<IActionResult> GE_STORE_DELIVERY()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_DELIVERY.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("STORE_DELIVERY_DETAILS")]
        //public async Task<IActionResult> GE_STORE_DELIVERY_DETAILS()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_DELIVERY_DETAILS.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("STORE_DELIVERY_DETAILS_DISCP_LOG")]
        //public async Task<IActionResult> GE_STORE_DELIVERY_DETAILS_DISCP_LOG()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_DELIVERY_DETAILS_DISCP_LOG.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("STORE_DELIVERY_REGISTER")]
        //public async Task<IActionResult> GE_STORE_DELIVERY_REGISTER()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_DELIVERY_REGISTER.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("STORE_DML")]
        //public async Task<IActionResult> GE_STORE_DML()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_DML.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("STORE_DML_CUSTOMER_WISE")]
        //public async Task<IActionResult> GE_STORE_DML_CUSTOMER_WISE()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_DML_CUSTOMER_WISE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("STORE_PRODUCT_BARCODE")]
        //public async Task<IActionResult> GE_STORE_PRODUCT_BARCODE()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_PRODUCT_BARCODE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}




        //[HttpGet]
        //[Route("STORE_REQUISITION")]
        //public async Task<IActionResult> GE_STORE_REQUISITION()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_REQUISITION.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("STORE_REQUISITION_WRK")]
        //public async Task<IActionResult> GE_STORE_REQUISITION_WRK()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_REQUISITION_WRK.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("STORE_SUPERVISOR")]
        //public async Task<IActionResult> GE_STORE_SUPERVISOR()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_SUPERVISOR.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("STORE_TRANSFER_PERMISSION")]
        //public async Task<IActionResult> GE_STORE_TRANSFER_PERMISSION()
        //{
        //    try
        //    {
        //        var result = await _context.STORE_TRANSFER_PERMISSION.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("StoreDelivery_Wrk")]
        //public async Task<IActionResult> GE_StoreDelivery_Wrk()
        //{
        //    try
        //    {
        //        var result = await _context.StoreDelivery_Wrk.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("StoreDeliveryDetails_wrk")]
        //public async Task<IActionResult> GE_StoreDeliveryDetails_wrk()
        //{
        //    try
        //    {
        //        var result = await _context.StoreDeliveryDetails_wrk.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("STOREDELIVERYRECEIVE")]
        //public async Task<IActionResult> GE_STOREDELIVERYRECEIVE()
        //{
        //    try
        //    {
        //        var result = await _context.STOREDELIVERYRECEIVE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
        //[HttpGet]
        //[Route("StoreDML_wrk")]
        //public async Task<IActionResult> GE_StoreDML_wrk()
        //{
        //    try
        //    {
        //        var result = await _context.StoreDML_wrk.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("StoreDML_wrkCustomerWise")]
        //public async Task<IActionResult> GE_StoreDML_wrkCustomerWise()
        //{
        //    try
        //    {
        //        var result = await _context.StoreDML_wrkCustomerWise.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("StoreLogo")]
        //public async Task<IActionResult> GE_StoreLogo()
        //{
        //    try
        //    {
        //        var result = await _context.StoreLogo.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}




        //[HttpGet]
        //[Route("StoreMetaData")]
        //public async Task<IActionResult> GE_StoreMetaData()
        //{
        //    try
        //    {
        //        var result = await _context.StoreMetaData.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("StoreMetaDataRubel")]
        //public async Task<IActionResult> GE_StoreMetaDataRubel()
        //{
        //    try
        //    {
        //        var result = await _context.StoreMetaDataRubel.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("StoreNotification")]
        //public async Task<IActionResult> GE_StoreNotification()
        //{
        //    try
        //    {
        //        var result = await _context.StoreNotification.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("StoreSetup")]
        //public async Task<IActionResult> GE_StoreSetup()
        //{
        //    try
        //    {
        //        var result = await _context.StoreSetup.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("StoreWiseMinimumQtyDel")]
        //public async Task<IActionResult> GE_StoreWiseMinimumQtyDel()
        //{
        //    try
        //    {
        //        var result = await _context.StoreWiseMinimumQtyDel.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("SUB_CATEGORY")]
        //public async Task<IActionResult> GE_SUB_CATEGORY()
        //{
        //    try
        //    {
        //        var result = await _context.SUB_CATEGORY.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("SUB_CATEGORY_Log")]
        //public async Task<IActionResult> GE_SUB_CATEGORY_Log()
        //{
        //    try
        //    {
        //        var result = await _context.SUB_CATEGORY_Log.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}




        //[HttpGet]
        //[Route("SUB_SUBCATEGORY")]
        //public async Task<IActionResult> GE_SUB_SUBCATEGORY()
        //{
        //    try
        //    {
        //        var result = await _context.SUB_SUBCATEGORY.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("SUB_SUBCATEGORY_Log")]
        //public async Task<IActionResult> GE_SUB_SUBCATEGORY_Log()
        //{
        //    try
        //    {
        //        var result = await _context.SUB_SUBCATEGORY_Log.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("SUB_SUBCATEGORY_VARIANCE")]
        //public async Task<IActionResult> GET_SUB_SUBCATEGORY_VARIANCE()
        //{
        //    try
        //    {
        //        var result = await _context.SUB_SUBCATEGORY_VARIANCE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("SUB_SUBCATEGORY_VARIANCE_VALUE")]
        //public async Task<IActionResult> GET_SUB_SUBCATEGORY_VARIANCE_VALUE()
        //{
        //    try
        //    {
        //        var result = await _context.SUB_SUBCATEGORY_VARIANCE_VALUE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("SUBCATEGORY_VARIANCE")]
        //public async Task<IActionResult> GET_SUBCATEGORY_VARIANCE()
        //{
        //    try
        //    {
        //        var result = await _context.SUBCATEGORY_VARIANCE.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("SubDepartment")]
        //public async Task<IActionResult> GET_SubDepartment()
        //{
        //    try
        //    {
        //        var result = await _context.SubDepartment.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("SubDepartment_Log")]
        //public async Task<IActionResult> GET_SubDepartment_Log()
        //{
        //    try
        //    {
        //        var result = await _context.SubDepartment_Log.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("SubSubcategory")]
        //public async Task<IActionResult> GET_SubSubcategory()
        //{
        //    try
        //    {
        //        var result = await _context.SubSubcategory.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("Temp_BillEntry")]
        //public async Task<IActionResult> GET_Temp_BillEntry()
        //{
        //    try
        //    {
        //        var result = await _context.Temp_BillEntry.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("Temp_BillPayment")]
        //public async Task<IActionResult> GET_Temp_BillPayment()
        //{
        //    try
        //    {
        //        var result = await _context.Temp_BillPayment.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("TEMP_CIRCULAR_DISCOUNT")]
        //public async Task<IActionResult> GET_TEMP_CIRCULAR_DISCOUNT()
        //{
        //    try
        //    {
        //        var result = await _context.TEMP_CIRCULAR_DISCOUNT.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}




        //[HttpGet]
        //[Route("TEMP_CUSTOMER_QUOTATION")]
        //public async Task<IActionResult> GET_TEMP_CUSTOMER_QUOTATION()
        //{
        //    try
        //    {
        //        var result = await _context.TEMP_CUSTOMER_QUOTATION.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("Temp_GLHO")]
        //public async Task<IActionResult> GET_Temp_GLHO()
        //{
        //    try
        //    {
        //        var result = await _context.Temp_GLHO.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("ThirdPartySalePostingLog")]
        //public async Task<IActionResult> GET_ThirdPartySalePostingLog()
        //{
        //    try
        //    {
        //        var result = await _context.ThirdPartySalePostingLog.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("UpdateRemove_Log")]
        //public async Task<IActionResult> GET_UpdateRemove_Log()
        //{
        //    try
        //    {
        //        var result = await _context.UpdateRemove_Log.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        //[HttpGet]
        //[Route("UsedDiscounts")]
        //public async Task<IActionResult> GET_UsedDiscounts()
        //{
        //    try
        //    {
        //        var result = await _context.UsedDiscounts.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("USER_MENU")]
        //public async Task<IActionResult> GET_USER_MENU()
        //{
        //    try
        //    {
        //        var result = await _context.USER_MENU.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}


        //[HttpGet]
        //[Route("USER_PRICE_PERMISSION")]
        //public async Task<IActionResult> GET_USER_PRICE_PERMISSION()
        //{
        //    try
        //    {
        //        var result = await _context.USER_PRICE_PERMISSION.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}

        //[HttpGet]
        //[Route("USER_PRICE_SHOW_PERMISSION")]
        //public async Task<IActionResult> GET_USER_PRICE_SHOW_PERMISSION()
        //{
        //    try
        //    {
        //        var result = await _context.USER_PRICE_SHOW_PERMISSION.ToListAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}



        [HttpGet]
        [Route("USERS")]
        public async Task<IActionResult> GET_USERS()
        {
            try
            {
                var result = await _context.USERS.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }

        [HttpGet]
        [Route("VARIANCE_ATTRIBUTE")]
        public async Task<IActionResult> GET_VARIANCE_ATTRIBUTE()
        {
            try
            {
                var result = await _context.VARIANCE_ATTRIBUTE.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }


        [HttpGet]
        [Route("VatIntegration")]
        public async Task<IActionResult> GET_VatIntegration()
        {
            try
            {
                var result = await _context.VatIntegration.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }




        [HttpGet]
        [Route("VEHICLE")]
        public async Task<IActionResult> GET_VEHICLE()
        {
            try
            {
                var result = await _context.VEHICLE.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }


        [HttpGet]
        [Route("VENDOR")]
        public async Task<IActionResult> GET_VENDOR()
        {
            try
            {
                var result = await _context.VENDOR.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }


        [HttpGet]
        [Route("VENDOR_ADDITIONAL_INFO")]
        public async Task<IActionResult> GET_VENDOR_ADDITIONAL_INFO()
        {
            try
            {
                var result = await _context.VENDOR_ADDITIONAL_INFO.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }



        [HttpGet]
        [Route("VENDOR_CONTACT")]
        public async Task<IActionResult> GET_VENDOR_CONTACT()
        {
            try
            {
                var result = await _context.VENDOR_CONTACT.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }


        [HttpGet]
        [Route("VENDOR_Log")]
        public async Task<IActionResult> GET_VENDOR_Log()
        {
            try
            {
                var result = await _context.VENDOR_Log.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }


        [HttpGet]
        [Route("VENDOR_REGISTRATION_INFO")]
        public async Task<IActionResult> GET_VENDOR_REGISTRATION_INFO()
        {
            try
            {
                var result = await _context.VENDOR_REGISTRATION_INFO.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }


        [HttpGet]
        [Route("VIRTUAL_STORE_INVENTORY")]
        public async Task<IActionResult> GET_VIRTUAL_STORE_INVENTORY()
        {
            try
            {
                var result = await _context.VIRTUAL_STORE_INVENTORY.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }


    }
}
