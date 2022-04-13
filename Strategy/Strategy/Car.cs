using System;
namespace Strategy
{
    public class Car
    {
        //Context
        //Наш класс который хранит ссылку на нашу стратегию 
        protected int passengers; // кол-во пассажиров
        protected string model; // модель автомобиля

        public Car(int num, string model, IStrategy mov)
        {
            this.passengers = num;
            this.model = model;
            Movable = mov;
        }
        public IStrategy Movable { private get; set; }
        public void Move()
        {
            Console.WriteLine("Модель машины " + model);
            Console.WriteLine("Количество пассажиров в машине " + passengers);
            Movable.Move();
        }
        public void Accelerate()
        {
            Movable.Accelerate();
        }
        public void Stop()
        {
            Movable.Stop();
        }
    }
}
