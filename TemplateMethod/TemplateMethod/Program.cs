using System;

namespace TemplateMethod
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            School school = new School();
            University university = new University();

            school.Learn();
            university.Learn();
        }
    }
}
