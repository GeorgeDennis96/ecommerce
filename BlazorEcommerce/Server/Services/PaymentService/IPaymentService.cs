using BlazorEcommerce.Shared;
using BlazorEcommerce.Shared.Models.Payment;
using Stripe;

namespace BlazorEcommerce.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        //Subscriptions
        public string CreateSubscription();
        public string RetrieveSubscription();
        public string UpdateSubscription();
        public string ListSubscriptions();
        public string CancelSubscription();
        public string DeleteSubscription();

        //Payment Intent
        public Task<ServiceResponse<PaymentIntent>> CreatePaymentIntent(decimal amout, string currency, string paymentMethodId);
        public string RetrievePaymentIntent();
        public string UpdatePaymentIntent();
        public string CapturePaymentIntent();
        public string ListPaymentIntent();
        public string CancelPaymentIntent();

    }
}
