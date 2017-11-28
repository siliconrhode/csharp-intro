using System;

namespace Classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("Hi, my first name is:" + FirstName + " last name is:"+LastName);
        }
    }
}