using System;
namespace StatePattern
{
    class Water
    {

        //Наш контекст который изменяет свое состояние 
        public IWaterState State { get; set; }

        public Water(IWaterState ws)
        {
            State = ws;
        }

        public void Heat()
        {
            State.Heat(this);
        }
        public void Frost()
        {
            State.Frost(this);
        }
    }
}
