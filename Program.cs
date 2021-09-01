using System;

namespace printing_names
{
    class Program
    {
        static void Main(string[] args)
        {
            People P1 = new People("John","Krasinski",40);
            Console.WriteLine(P1.find_details());
        }
    }
}
