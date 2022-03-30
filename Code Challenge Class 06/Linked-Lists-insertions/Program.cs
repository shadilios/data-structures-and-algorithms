using System;

namespace Linked_Lists_insertions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Append
            //2- InsertBefore
            //3- InsertAfter

            MyList list = new MyList();
            list.AddToEnd(1);
            list.AddToEnd(2);
            list.AddToEnd(3);
            list.AddToEnd(4);
            list.AddToEnd(5);
            list.AddToEnd(6);
            list.AddToEnd(7);

            list.InsertAfter(99, 2);

            list.Print();
            

        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }

        public void Print()
        {
            Console.Write("|" + data + "|->");
            if (next != null)
            {
                next.Print();
            }
        }

        public void InsertBefore(int data, int value)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else if (next.data == value)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.InsertBefore(data, value);
            }
        }

        public void InsertAfter(int data, int value)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else if(next.data == value)
            {
                Node temp = new Node(data);
                temp.next = this.next.next;
                this.next.next = temp;
            }
            else
            {
                next.InsertAfter(data, value);
            }
        }

        public void AddSorted(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(data);
            }
        }

        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }
    }

    public class MyList
    {
        public Node headNode;

        public MyList()
        {
            headNode = null;
        }

        //data is what we add, value what we compare with
        public void InsertBefore(int data, int value)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if(value == headNode.data)
            {
                AddToBeginning(data);
            }
            else
            {
                headNode.InsertBefore(data, value);
            }
        }

        public void InsertAfter(int data, int value)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if(value == headNode.data)
            {
                Console.WriteLine("IDK HOW DO I ADD AFTER FIRST ELEMENT");
            }
            else
            {
                headNode.InsertAfter(data, value);
            }
        }

        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }

        public void AddSorted(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)
            {
                AddToBeginning(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }

        public void AddToBeginning(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

        public void Print()
        {
            if (headNode!= null)
            {
                headNode.Print();
            }
        }
    }
}
