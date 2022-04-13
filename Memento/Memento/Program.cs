using System;

namespace Memento
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            SalesProspect s = new SalesProspect();
            s.firstName = "Nichita";
            s.lastName = "Macheev";
            s.Address = "Dacia 18";
            s.phoneName = "Iphone";
            s.Memory = "256";
            s.Camera = "12 px";
            s.Budget = "25000.0";
            // Делаем снимок 
            ProspectMemory m = new ProspectMemory();
            //Сохраняем данные 
            m.Memento = s.SaveMemento();

            // Изменяем на новые данные 
            Console.WriteLine("Желаете изменить данные ? y/n");
            var temp = Console.ReadLine();
            if (temp == "y") {
                Console.WriteLine("Введите имя:");
                s.firstName = Console.ReadLine();

                Console.WriteLine("Введите фамилию:");
                s.lastName = Console.ReadLine();

                Console.WriteLine("Введите адресс:");
                s.Address = Console.ReadLine();

                Console.WriteLine("Введите название телефона:");
                s.phoneName = Console.ReadLine();

                Console.WriteLine("Введите память телефона:");
                s.Memory = Console.ReadLine();

                Console.WriteLine("Введите камеру:");
                s.Camera = Console.ReadLine();

                Console.WriteLine("Введите бюджет:");
                s.Budget = Console.ReadLine();

                Console.WriteLine("New dates: \n " +
                    "Frist Name: {0} \n Last Name: {1} \n Address: {2} \n Phone name: {3} \n Memory: {4} \n" +
                    " Camera: {5} \n Budget: {6} \n", s.firstName, s.lastName, s.Address, s.phoneName, s.Memory,
                    s.Camera, s.Budget);
            }

            Console.WriteLine("Желаете восстановить данные ? y/n");
            temp = Console.ReadLine();
            // восстанавливаем старые данные
            if (temp == "y")s.RestoreMemento(m.Memento);
        }
    }
}
