using System;
namespace StatePattern
{
    class GasWaterState:IWaterState
    {
        //Реализация состояния 
        public void Heat(Water water)
        {
            Console.WriteLine("Повышаем температуру водяного пара");
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем водяной пар в жидкость");
            water.State = new LiquidWaterState();
        }
    }
}
