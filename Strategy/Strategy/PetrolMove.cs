using System;
namespace Strategy
{
    public class PetrolMove:IStrategy
    {
        public void Accelerate()
        {
            Console.WriteLine("Ускорение машины");
        }

        //Конкретная стратегия 
        public void Move()
        {
            Console.WriteLine("Перемещение на бензине");
        }

        public void Stop()
        {
            Console.WriteLine("Остановка машины");
        }
    }
}
