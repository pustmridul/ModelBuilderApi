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

        [HttpGet]
        [Route("Department_Log")]
        public async Task<IActionResult> GetDepartment_Log()
        {
            try
            {
                var result = await _context.Department_Logs.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }

        [HttpGet]
        [Route("DESIRED_STOCK_SETUP")]
        public async Task<IActionResult> GetDESIRED_STOCK_SETUP()
        {
            try
            {
                var result = await _context.DESIRED_STOCK_SETUPS.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }

        [HttpGet]
        [Route("BookingDetails")]
        public async Task<IActionResult> GetBookingDetails()
        {
            try
            {
                var result = await _context.BookingDetails.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
    }
}
