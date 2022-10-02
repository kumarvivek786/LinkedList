using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    internal class linkedlist
    {
            public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list",data);
        }

        public void AddFirst(int data)
        {   //creating new node
            Node newnode = new Node(data);//30
            //first node address to new node using head
            newnode.next = head;//70
            //moving head refrence to new node
            head = newnode;
            Console.WriteLine("{0} inserted into the linked list", data);
        }
        
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }

        }
    }
}

