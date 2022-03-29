using System;

namespace ChainOfResponsibility
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Receiver receiver = new Receiver(false, true, true);

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();

            bankPaymentHandler.Handle(receiver);
            moneyPaymentHadler.Handle(receiver);
            paypalPaymentHandler.Handle(receiver);
        }
        
    }
}
