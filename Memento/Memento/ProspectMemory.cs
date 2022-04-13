using System;
namespace Memento
{
    public class ProspectMemory
    { 
        //Хранитель обьекта memento (Caretaker)
        Memento memento;
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
