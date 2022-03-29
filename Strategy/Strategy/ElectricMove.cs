using System;
namespace Strategy
{
    public class ElectricMove:IMovable
    {
        //Конкретная стратегия 
        public void Move() {
            Console.WriteLine("Перемещение с помощью электричества");
        }
    }
}
