using api_gateway_mascoschool.Model;

namespace api_gateway_mascoschool.Repository
{
    public interface IPaymentGetway
    {
        Task<WrapperPaymentGetwayModel> GetPaymentDataList(Param obj);
    }
}
