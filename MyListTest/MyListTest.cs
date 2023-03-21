using Lab2_MTSD;

namespace MyListTest
{
    [TestClass]
    public class MyListTest
    {
        [TestMethod]
        public void Test_Get_Specific_Length()
        {
            MyList myList = new();

            myList.Append('a');
            myList.Append('b');

            Assert.AreEqual(2, myList.Length());
        }

        [TestMethod]
        public void Test_Append_Element()
        {
            MyList myList = new();

            myList.Append('d');

            Assert.AreEqual('d', myList.Get(0));
        }

        [TestMethod]
        public void Test_Insert_Element_At_OutOfRange_Index()
        {
            MyList myList = new();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => myList.Insert('e', 3));
        }

        [TestMethod]
        public void Test_Insert_Element_At_Specific_Index()
        {
            MyList myList = new();

            myList.Append('a');
            myList.Insert('f', 0);

            Assert.AreEqual('f', myList.Get(0));
        }

        [TestMethod]
        public void Test_Delete_Element_At_OutOfRange_Index()
        {
            MyList myList = new();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => myList.Delete(3));
        }

        [TestMethod]
        public void Test_Delete_Returned_Element()
        {
            MyList myList = new();

            myList.Append('g');
            
            Assert.AreEqual('g', myList.Delete(0));
        }

        [TestMethod]
        public void Test_Delete_Element_At_Index()
        {
            MyList myList = new();

            myList.Append('g');
            myList.Append('g');
            myList.Delete(1);

            Assert.AreEqual(1, myList.Length());
        }

        [TestMethod]
        public void Test_Delete_All_Elements()
        {
            MyList myList = new();

            myList.Append('g');
            myList.Append('h');
            myList.Append('h');
            myList.DeleteAll('h');

            Assert.AreEqual(1, myList.Length());
        }

        [TestMethod]
        public void Test_Get_Element_At_Index()
        {
            MyList myList = new();

            myList.Append('i');

            Assert.AreEqual('i', myList.Get(0));
        }

        [TestMethod]
        public void Test_Get_Element_At_OutOfRange_Index()
        {
            MyList myList = new();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => myList.Get(3));
        }

        [TestMethod]
        public void Test_Clone_List()
        {
            MyList myList = new();

            myList.Append('j');
            MyList clone = myList.Clone();

            Assert.IsNotNull(clone);
            Assert.AreNotSame(myList, clone);
            Assert.AreEqual('j', clone.Get(0));
        }

        [TestMethod]
        public void Test_Reverse_List()
        {
            MyList myList = new();

            myList.Append('k');
            myList.Append('l');
            myList.Reverse();

            Assert.AreEqual('l', myList.Get(0));
            Assert.AreEqual('k', myList.Get(1));
        }

        [TestMethod]
        public void Test_Find_First_Element()
        {
            MyList myList = new();

            myList.Append('l');
            myList.Append('m');
            myList.Append('m');

            Assert.AreEqual(1, myList.FindFirst('m'));
        }

        [TestMethod]
        public void Test_Find_Last_Element()
        {
            MyList myList = new();

            myList.Append('n');
            myList.Append('n');

            Assert.AreEqual(1, myList.FindLast('n'));
        }

        [TestMethod]
        public void Test_Clear_List()
        {
            MyList myList = new();

            myList.Append('o');
            myList.Append('p');
            myList.Clear();

            Assert.AreEqual(0, myList.Length());
        }

        [TestMethod]
        public void Test_Extend_With_List()
        {
            MyList myList = new();
            myList.Append('q');
            MyList myList2 = new();
            myList2.Append('r');

            myList.Extend(myList2);

            Assert.AreEqual(2, myList.Length());
            Assert.AreEqual('r', myList.Get(1));
        }
    }
}