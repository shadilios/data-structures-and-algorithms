using System;
using Xunit;
using Linked_Lists;


namespace Linked_List_Test
{
    public class UnitTest1
    {
        //1- Can instantiate empty object
        [Fact]
        public void CanInstantiate()
        {
            MyList list = new MyList();

            Assert.NotNull(list);
        }


        //2- Can insert into the linked list
        [Fact]
        public void CanInsert()
        {
            MyList list = new MyList();

            list.AddToStart(5);

            Assert.Equal(5, list.headNode.data);
        }

        //3- The head property will properly point to the first node in the linked list
        [Fact]
        public void HeadPointsToFirstNode()
        {
            MyList list = new MyList();

            list.AddToStart(7);
            list.AddToStart(5);
            list.AddToStart(10);

            Assert.Equal(10, list.headNode.data);

        }

        //4- Can properly insert multiple nodes into the linked list


        //5- Will return true when finding a value within the linked list that exists
        [Fact]
        public void CanSearchTrue()
        {
            MyList list = new MyList();

            list.AddSorted(5);
            list.AddSorted(6);
            list.AddSorted(7);
            list.AddSorted(8);
            list.AddSorted(9);

            Assert.True(list.Search(7));

        }

        //6- Will return false when searching for a value in the linked list that does not exist
        [Fact]
        public void CanSearchFalse()
        {
            MyList list = new MyList();

            list.AddSorted(5);
            list.AddSorted(6);
            list.AddSorted(7);
            list.AddSorted(8);
            list.AddSorted(9);

            Assert.False(list.Search(321561));
        }

        //7- Can properly return a collection of all the values that exist in the linked list

    }
}
