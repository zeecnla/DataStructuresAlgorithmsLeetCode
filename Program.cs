using System;
using Data_Structures;

namespace DatabaseAndAlgorithmsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine("Data Structures");
            //TestLinkedListDS();



            Console.WriteLine("Algorithms");



            Console.ReadLine();
        }

        private static void TestLinkedListDS()
        {
            LinkedList linkedList = new LinkedList();

            linkedList.Add(2);
            linkedList.Add(4);
            linkedList.Add(6);
            linkedList.Add(8);
            linkedList.Add(10);

            Console.WriteLine(linkedList.ToString());

            linkedList.Delete();
            //test deelte oncde
            Console.WriteLine(linkedList.ToString());

            linkedList.Delete();
            linkedList.Delete();
            linkedList.Delete();
            linkedList.Delete();
            linkedList.Delete();


            Console.WriteLine("all items deleted " + linkedList.ToString());
        }
    }
}
