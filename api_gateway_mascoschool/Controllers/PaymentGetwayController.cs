using api_gateway_mascoschool.Model;
using api_gateway_mascoschool.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_gateway_mascoschool.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/PaymentGetway/")]
    [ApiController]
    public class PaymentGetwayController : ControllerBase
    {
        private readonly IPaymentGetway _pGetway;
        public PaymentGetwayController(IPaymentGetway pGetway)
        {
            _pGetway = pGetway;
        }   
        [HttpGet("get-paymentInfo")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> GetEmployee([FromBody] Param obj)
        {
            WrapperPaymentGetwayModel result = new WrapperPaymentGetwayModel();
            result = await _pGetway.GetPaymentDataList(obj);

            return Ok(result);

        }
    }
}
