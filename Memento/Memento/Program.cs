using System;

namespace Memento
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Nichita Macheev";
            s.Phone = "068030941";
            s.Budget = 25000.0;

            // Делаем снимок 
            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();
            // Изменяем на новые данные 
            s.Name = "Leo Leo";
            s.Phone = "069321583";
            s.Budget = 1000000.0;
            // восстанавливаем старые данные
            s.RestoreMemento(m.Memento);
        }
    }
}
