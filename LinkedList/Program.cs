﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DataStructure Linkedlist!");
            linkedlist list = new linkedlist();
            
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.AddFirst(70);
            //list.AddFirst(30);
            //list.AddFirst(56);
            list.Append(56);
           // list.Append(30);
            list.Append(70);
            Console.Write("\nLinked List:\n");
            list.Display();
            list.InsertAtPosition(2, 30);
            Console.Write("After Inserted 30 in between 56 and 70 :\nLinked List :\n");
            list.Display();
            Console.ReadLine();

        }
    }
}
