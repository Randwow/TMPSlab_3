﻿using System;

namespace Strategy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car auto = new Car(4, "Volvo", new PetrolMove());
            auto.Move();
            auto.Accelerate();
            auto.Stop();
            auto.Movable = new ElectricMove();
            auto.Move();
        }
    }
}
