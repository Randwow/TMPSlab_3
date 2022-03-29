using System;
namespace ChainOfResponsibility
{
    public class BankPaymentHandler:PaymentHandler
    {
        //Проверяет сопостовимость типа платежа если схрдится выполняется транзакция
        // если нет то деньги остаются в системе 
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
                Console.WriteLine("Выполняем банковский перевод");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
