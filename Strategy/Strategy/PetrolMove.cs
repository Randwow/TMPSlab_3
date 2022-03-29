using System;
namespace Strategy
{
    public class PetrolMove:IMovable
    {
        //Конкретная стратегия 
        public void Move()
        {
            Console.WriteLine("Перемещение на бензине");
        }
    }
}
