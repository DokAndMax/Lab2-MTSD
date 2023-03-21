using System.Threading;

namespace Lab2_MTSD
{
    public class MyList
    {
        private class Node
        {
            public char Value;
            public Node Next;
            public Node Prev;

            public Node(char value)
            {
                Value = value;
            }
        }
        private Node? head;
        private Node? tail;
        private int count = 0;

        public int Length()
        {
            return count;
        }

        public void Append(char element)
        {
            Node newNode = new(element);
            if (tail is null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
            count++;
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
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException();
            }

            Node? node = head;
            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }
            return node.Value;
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
