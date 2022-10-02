using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DataStructure Linkedlist!");
            linkedlist list = new linkedlist();
            list.Add(30);
            list.Add(56);
            list.Add(70);
            Console.Write("\nLinked List:\n");
            list.Display();
            Console.ReadLine(); 
        }
    }
}
