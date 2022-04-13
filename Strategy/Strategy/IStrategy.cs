using System;
namespace Strategy
{
    public interface IStrategy
    {
        //Этот интерфейс наш IStrategy 
        void Move();
        //
        void Accelerate();
        //
        void Stop();
    }
}
