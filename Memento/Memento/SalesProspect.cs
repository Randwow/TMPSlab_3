using System;
namespace Memento
{
    public class SalesProspect
    {
        string first_name;
        string last_name;
        string address;
        string phone_name;
        string phone_memory;
        string phone_camera;
        string budget;
        // Gets or sets name
        public string firstName
        {
            get { return first_name; }
            set
            {
                first_name = value;
                Console.WriteLine("Frist Name:   " + first_name);
            }
        }
        public string lastName
        {
            get { return last_name; }
            set
            {
                last_name = value;
                Console.WriteLine("Last Name:   " + last_name);
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                Console.WriteLine("Address:   " + address);
            }
        }
        // Gets or sets phone
        public string phoneName
        {
            get { return phone_name; }
            set
            {
                phone_name = value;
                Console.WriteLine("Phone name:  " + phone_name);
            }
        }
        public string Memory
        {
            get { return phone_memory; }
            set
            {
                phone_memory = value;
                Console.WriteLine("Phone memory:  " + phone_memory);
            }
        }
        public string Camera
        {
            get { return phone_camera; }
            set
            {
                phone_camera = value;
                Console.WriteLine("Phone camera:  " + phone_camera);
            }
        }
        // Gets or sets budget
        public string Budget
        {
            get { return budget; }
            set
            {
                budget = value;
                Console.WriteLine("Budget: " + budget);
            }
        }
        // Метод для сохранения 
        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento(first_name, last_name, address, phone_name, phone_camera, phone_memory ,budget);
        }
        // метод для восстановления 
        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            firstName = memento.firstName;
            lastName = memento.lastName;
            Address = memento.Address;
            phoneName = memento.phoneName;
            Memory = memento.Memory;
            Camera = memento.Camera;
            Budget = memento.Budget;
        }
    }
}
