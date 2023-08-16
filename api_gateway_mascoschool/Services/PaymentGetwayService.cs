using api_gateway_mascoschool.Data;
using api_gateway_mascoschool.Model;
using api_gateway_mascoschool.Repository;
using Dapper;

namespace api_gateway_mascoschool.Services
{
    public class PaymentGetwayService:IPaymentGetway
    {
        private readonly DapperContext _context;
        private readonly IConfiguration _config;
        public PaymentGetwayService(DapperContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public async Task<WrapperPaymentGetwayModel> GetPaymentDataList(Param obj)
        {
            WrapperPaymentGetwayModel wrapper = new WrapperPaymentGetwayModel();
            var query = "EXEC [dbo].[sp_get_payment_Info] @TransId";

            using (var connection = _context.CreateConnection())
            {
                var _parameter = new DynamicParameters();
                _parameter.Add("@TransId", obj.TransId);

                var result = await connection.QueryAsync<PaymentGetwayModel>(query, _parameter);

                wrapper._dataList = result.ToList();

            }
            return wrapper;
        }
     
    }
}
