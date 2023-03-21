using Lab2_MTSD;

internal class Program
{
    private static void Main(string[] args)
    {
        MyList myList = new();

        Console.WriteLine("myList.Append('h'); myList.Append('i');");
        myList.Append('h');
        myList.Append('i');
        PrintAllMyListElements(myList);

        Console.WriteLine("\nmyList.Length()");
        Console.WriteLine(myList.Length());

        Console.WriteLine("\nmyList.Get(1)");
        Console.WriteLine(myList.Get(1));

        Console.WriteLine("\nMyList myListClone = myList.Clone();");
        MyList myListClone = myList.Clone();
        PrintAllMyListElements(myListClone);

        Console.WriteLine("\nmyListClone.Reverse();");
        myListClone.Reverse();
        PrintAllMyListElements(myListClone);

        Console.WriteLine("\nmyList.Extend(myListClone);");
        myList.Extend(myListClone);
        PrintAllMyListElements(myList);

        Console.WriteLine("\nmyList.FindFirst('i');");
        Console.WriteLine(myList.FindFirst('i'));

        Console.WriteLine("\nmyList.FindLast('i');");
        Console.WriteLine(myList.FindLast('i'));

        Console.WriteLine("\nmyList.DeleteAll('h');");
        myList.DeleteAll('h');
        PrintAllMyListElements(myList);

        Console.WriteLine("\nmyList.Insert('m', 1);");
        myList.Insert('m', 1);
        PrintAllMyListElements(myList);

        Console.WriteLine("\nmyList.Delete(0);");
        myList.Delete(0);
        PrintAllMyListElements(myList);

        Console.WriteLine("\nmyList.Clear();");
        myList.Clear();
        PrintAllMyListElements(myList);
    }

    private static void PrintAllMyListElements(MyList list)
    {
        Console.Write("Elements: ");
        List<char> elements = new();

        for(int i = 0; i < list.Length(); i++)
        {
            elements.Add(list.Get(i));
        }

        Console.WriteLine($"{string.Join(", ", elements)}");
    }
}