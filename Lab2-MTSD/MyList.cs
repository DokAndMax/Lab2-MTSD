namespace Lab2_MTSD
{
    public class MyList
    {
        private List<char> list = new();

        public int Length()
        {
            return list.Count;
        }

        public void Append(char element)
        {
            list.Add(element);
        }

        public void Insert(char element, int index)
        {
            if (index < 0 || index > list.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            list.Insert(index, element);
        }

        public char Delete(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            char element = list[index];
            list.RemoveAt(index);
            return element;
        }

        public void DeleteAll(char element)
        {
            list.RemoveAll(e => e == element);
        }

        public char Get(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return list[index];
        }

        public MyList Clone()
        {
            MyList newList = new()
            {
                list = new List<char>(list)
            };
            return newList;
        }

        public void Reverse()
        {
            list.Reverse();
        }

        public int FindFirst(char element)
        {
            return list.IndexOf(element);
        }

        public int FindLast(char element)
        {
            return list.LastIndexOf(element);
        }

        public void Clear()
        {
            list.Clear();
        }

        public void Extend(MyList elements)
        {
            list.AddRange(elements.list);
        }
    }
}
