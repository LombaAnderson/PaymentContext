namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        private IList<Payment> _payments;
        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateTime = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
            
        }


         public DateTime CreateDate { get; private set;}

         public DateTime LastUpdateTime { get; private set;}

         public DateTime? ExpireDate { get; private set;}

         public bool Active { get; private set;}

         public IReadOnlyCollection<Payment> Payments{get; private set;}

         public void AddPayment(Payment payment)
         {
               _payments.Add(payment);
         }

         public void Activate(){
            Active = true;
            LastUpdateTime = DateTime.Now;
         }

        public void Inactivate(){
            Active = false;
            LastUpdateTime = DateTime.Now;
         }
        
    }
}