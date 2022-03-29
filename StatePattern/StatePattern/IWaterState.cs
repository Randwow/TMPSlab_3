using System;
namespace StatePattern
{
    interface IWaterState
    {
        //Определяет интерфейс состояния 
        void Heat(Water water);
        void Frost(Water water);
    }
}
