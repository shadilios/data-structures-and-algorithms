using System;
using Xunit;
using Linked_Lists_insertions;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddToEnd()
        {
            MyList list = new MyList();
            list.AddToEnd(5);
            list.AddToEnd(6);

            Assert.Equal(6, list.headNode.next.data);
        }

        [Fact]
        public void CanAddToEndMultiple()
        {
            MyList list = new MyList();
            list.AddToEnd(5);
            list.AddToEnd(6);
            list.AddToEnd(7);

            Assert.Equal(6, list.headNode.next.data);
            Assert.Equal(7, list.headNode.next.next.data);

        }

        [Fact]
        public void CanInsertBefore()
        {
            MyList list = new MyList();

            list.AddToEnd(1);
            list.AddToEnd(2);
            list.AddToEnd(3);

            list.InsertBefore(99, 2);

            Assert.Equal(99, list.headNode.next.data);
        }

        [Fact]
        public void CanInsertBeforeTheFirst()
        {
            MyList list = new MyList();

            list.AddToEnd(1);
            list.AddToEnd(2);
            list.AddToEnd(3);

            list.InsertBefore(99, 1);


            Assert.Equal(99, list.headNode.data);
        }

        [Fact]
        public void CanInsertAfter()
        {
            MyList list = new MyList();

            list.AddToEnd(1);
            list.AddToEnd(2);
            list.AddToEnd(3);

            list.InsertAfter(99, 2);


            Assert.Equal(99, list.headNode.next.next.data);
        }

        [Fact]
        public void CanInsertAfterTheLast()
        {
            MyList list = new MyList();

            list.AddToEnd(1);
            list.AddToEnd(2);
            list.AddToEnd(3);

            list.InsertAfter(99, 3);


            Assert.Equal(99, list.headNode.next.next.next.data);
        }
    }
}
