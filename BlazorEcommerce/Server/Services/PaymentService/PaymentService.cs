using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Shared;
using Microsoft.EntityFrameworkCore;
using Stripe;
using System.Configuration;

namespace BlazorEcommerce.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        public PaymentService()
        {
            StripeConfiguration.ApiKey = ConfigManager.GetVariable("stripe-api-key");
        }

        public string CancelPaymentIntent()
        {
            throw new NotImplementedException();
        }

        public string CancelSubscription()
        {
            throw new NotImplementedException();
        }

        public string CapturePaymentIntent()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<PaymentIntent>> CreatePaymentIntent(decimal amount, string currency, string paymentMethodId)
        {
            var response = new ServiceResponse<PaymentIntent>();

            try
            {
                var options = new PaymentIntentCreateOptions
                {
                    Amount = (long)(amount * 100), // convert to cents
                    Currency = currency,
                    PaymentMethod = paymentMethodId,
                    Confirm = true, // confirm the payment intent immediately
                    ErrorOnRequiresAction = true // error if authentication is required
                };

                var intent = await new PaymentIntentService().CreateAsync(options);

                response.Data = intent;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                response.Success = false;
                throw;
            }
            return response;
        }

        public string CreateSubscription()
        {
            throw new NotImplementedException();
        }

        public string DeleteSubscription()
        {
            throw new NotImplementedException();
        }

        public string ListPaymentIntent()
        {
            throw new NotImplementedException();
        }

        public string ListSubscriptions()
        {
            throw new NotImplementedException();
        }

        public string RetrievePaymentIntent()
        {
            throw new NotImplementedException();
        }

        public string RetrieveSubscription()
        {
            throw new NotImplementedException();
        }

        public string UpdatePaymentIntent()
        {
            throw new NotImplementedException();
        }

        public string UpdateSubscription()
        {
            throw new NotImplementedException();
        }
    }
}
