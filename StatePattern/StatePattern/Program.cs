using System;

namespace StatePattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();
            Console.WriteLine("\n");
            Water water1 = new Water(new GasWaterState());
            water1.Heat();
            water1.Frost();
            water.Frost();
            Console.WriteLine("\n");
            Water water2 = new Water(new SolidWaterState());
            water2.Heat();
            water2.Frost();
        }
    }
}
