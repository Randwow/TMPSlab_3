using System;
namespace Memento
{
    public class Memento
    {
        string first_name;
        string last_name;
        string address;
        string phone_name;
        string phone_memory;
        string phone_camera;
        string budget;
        // Constructor
        public Memento(string fname,string lname, string addr, string name_phone,
                       string camera_phone,string memory, string budget)
        {
            this.first_name = fname;
            this.last_name = lname;
            this.address = addr;
            this.phone_name = name_phone;
            this.phone_memory = memory;
            this.phone_camera = camera_phone;
            this.budget = budget;
        }
        public string firstName
        {
            get { return first_name; }
            set { first_name = value; }
        }
        public string lastName
        {
            get { return last_name; }
            set { last_name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string phoneName
        {
            get { return phone_name; }
            set { phone_name = value; }
        }
        public string Memory
        {
            get { return phone_memory; }
            set { phone_memory = value; }
        }
        public string Camera
        {
            get { return phone_camera; }
            set { phone_camera = value; }
        }
        public string Budget
        {
            get { return budget; }
            set { budget = value; }
        }
    }
}
