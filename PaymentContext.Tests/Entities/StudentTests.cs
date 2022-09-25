using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{

    [TestClass]

    public class StudentTests
    {
       [TestMethod]

       public void AdicionarAssinatura()
       {
          var subscription = new Subscription(null);
          var student = new Student("Anderson", "Lomba", "0789324912", "lomba@gmail.com");
          student.AddSubscription(subscription);


       }

    }


}