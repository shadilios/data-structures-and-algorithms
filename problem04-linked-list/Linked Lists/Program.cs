using System;

namespace Linked_Lists
{
    //  !!NOTE: I added some extra functions to the project because we didn't really apply actualy code and I was learning within the project

    
    public class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
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
        
        //modify this function to complete the search functionality
        public void Search(int data)
        {

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
                temp.next = next;
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

        public void AddToStart(int data)
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
        
        public bool Search(int data)
        {
            Node temp = headNode;

            while (temp != null)
            {
                if (temp.data == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        public void AddSorted(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)
            {
                AddToStart(data);
            }
            else
            {
                headNode.AddSorted(data);
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
        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }
    }

    public class Program
    {

        static void Main(string[] args)
        {
           MyList list = new MyList();
            list.AddSorted(9);
            list.AddSorted(5);
            list.AddSorted(7);
            list.AddSorted(11);
            list.Print();

            Console.WriteLine(list.Search(654165));

        }
    }
    

}
