using System;
namespace ChainOfResponsibility
{
    public abstract class PaymentHandler
    {
        //Абстракция которая будет проверять установку у получателя определенного типа платежа 
            public PaymentHandler Successor { get; set; }
            public abstract void Handle(Receiver receiver);

    }
}
