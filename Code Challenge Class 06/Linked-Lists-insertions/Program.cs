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


            //KTH FUNCTION CODE

            Console.WriteLine("");
            int myKey = 5;
            Console.WriteLine($"The Kth element of {myKey} is: ");
            Console.WriteLine(list.Kth(myKey));
            

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

        public int Kth(int y)
        {
            //First i have to find how many elements i have [use counter]
            //if the user inputs 0, I have to get back the last element
            //if the user inputs 1, i have to get back the element before the last...and so on
            //so length - input!

            int key = y;
            int firstCounter = 0;
            int secondCounter = 0;
            Node temp = headNode;
            int result = 1;

            //loop through list to find length
            while (temp != null)
            {
                //check
                firstCounter++;
                temp = temp.next;
            }

            //reset
            temp = headNode;

            //loop again to specific element to get data
            while (temp != null)
            {
                if (key > firstCounter)
                {
                    Console.WriteLine("Error, your key is bigger than the number of elements in the list, returning the first element");
                    return result;
                }

                secondCounter++;
                if (secondCounter == (firstCounter - key))
                {
                    result = temp.data;
                    break;
                }
                else
                {
                    temp = temp.next;
                }
            }

            return result;
        }
    }
}
