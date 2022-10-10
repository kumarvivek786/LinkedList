using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            Console.WriteLine("{0} inserted into the linked list", data);
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
                Console.WriteLine("invalid Position");
            if (position == 1)
            {
                Node newnode = new Node(data);
                newnode.next = head;
                head = newnode;
            }
            else
            {
                while (position != 0)
                    if (position == 1)
                    {
                        Node newnode = new Node(data);
                        newnode.next = head;
                        head = newnode;
                    }
            }
            if (position != 0)
                Console.WriteLine("out of range");
            Console.WriteLine("inserted node" + head);
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

        public Node RemoveLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
    }
}


