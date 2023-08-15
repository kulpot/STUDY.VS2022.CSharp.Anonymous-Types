using System;
using System.Linq;

//ref link:https://www.youtube.com/watch?v=u8C9iO_4yIQ&list=PL259BC2977085CF37&index=3
//anonymous types -- only stores data, relies to compiler, problems with CLR(CommonLanguangeRuntime)

static class MainClass
{
    class arbitraryClass
    {
        public arbitraryClass(string firstName, string lastName,
            int age, double gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            GPA = gpa;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public double GPA { get; private set; }
    }
    static void Main()
    {
        //var instance =
        //    new
        //    {
        //        FirstName = "Kulpot",
        //        LastName = "King",
        //        Age = 12,
        //        GPA = 4.1
        //    };
        //instance.LastName = "CantBeChange"; // error - anonymous types -- immutable means cant be change only stores
        //Console.WriteLine(instance.LastName);
        //Console.WriteLine(instance.FirstName);
        //Console.WriteLine(instance.GPA);

        var instance =
            new arbitraryClass("Kulpot", "King", 12, 4.1);
        //instance.Age = 55;    // error -- still immutable
        Console.WriteLine(instance.LastName);
        Console.WriteLine(instance.FirstName);
        Console.WriteLine(instance.GPA);
    }
}