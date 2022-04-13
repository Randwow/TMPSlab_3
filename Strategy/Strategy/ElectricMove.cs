using System;
namespace Strategy
{
    public class ElectricMove :IStrategy
    {
        
        //Конкретная стратегия 
        public void Move() {
            Console.WriteLine("Перемещение с помощью электричества" );
        }
        public void Accelerate()
        {
            Console.WriteLine("Ускорение машины");
        }
        public void Stop()
        {
            Console.WriteLine("Остановка машины");
        }

    }
}
