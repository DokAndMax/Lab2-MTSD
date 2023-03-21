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

            Assert.AreEqual(myList.Length(), 2);
        }

        [TestMethod]
        public void Test_Append_Element()
        {
            MyList myList = new();

            myList.Append('d');

            Assert.AreEqual(myList.Get(0), 'd');
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

            Assert.AreEqual(myList.Get(0), 'f');
        }

        [TestMethod]
        public void Test_Delete_Element_At_Index()
        {
        }

        [TestMethod]
        public void Test_Delete_All_Elements()
        {
        }

        [TestMethod]
        public void Test_Get_Element_At_Index()
        {
        }

        [TestMethod]
        public void Test_Clone_List()
        {
        }

        [TestMethod]
        public void Test_Reverse_List()
        {
        }

        [TestMethod]
        public void Test_Find_First_Element()
        {
        }

        [TestMethod]
        public void Test_Find_Last_Element()
        {
        }

        [TestMethod]
        public void Test_Clear_List()
        {
        }

        [TestMethod]
        public void Test_Extend_With_List()
        {
        }
    }
}