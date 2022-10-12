using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class linkedlist
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

        public void Append(int data)
        {
            Add(data);
        }

        public Node InsertAtPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid Position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                }
                if (position != 1)
                {
                    Console.WriteLine("Position out of range");
                }
            }
            return head;

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


