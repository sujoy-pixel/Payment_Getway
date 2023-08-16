namespace api_gateway_mascoschool.Model
{ 
    public class PaymentGetwayModel
    {
        public int ID { get; set; }
      
    }
    public class WrapperPaymentGetwayModel
    {
        public List<PaymentGetwayModel> _dataList { get; set; }
        public string error { get; set; }
    }
    public class Param
    {
        public string TransId { get; set; }
    }
}
