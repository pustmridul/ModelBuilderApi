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

        [HttpGet]
        [Route("CREDIT_COLLECTION")]
        public async Task<IActionResult> GetCREDIT_COLLECTION()
        {
            try
            {
                var result = await _context.CREDIT_COLLECTIONS.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }

        [HttpGet]
        [Route("CREDIT_NOTE")]
        public async Task<IActionResult> GetCREDIT_NOTE()
        {
            try
            {
                var result = await _context.CREDIT_NOTES.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet]
        [Route("CUSTOMER")]
        public async Task<IActionResult> GetCUSTOMER()
        {
            try
            {
                var result = await _context.CUSTOMERS.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpGet]
        [Route("CUSTOMER_BARCODE")]
        public async Task<IActionResult> GetCUSTOMER_BARCODE()
        {
            try
            {
                var result = await _context.CUSTOMER_BARCODES.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
    }
}
