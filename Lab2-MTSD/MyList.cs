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
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException();
            }

        }

        public char Delete(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException();
            }

            return '\0';
        }

        public void DeleteAll(char element)
        {
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
            return this;
        }

        public void Reverse()
        {
        }

        public int FindFirst(char element)
        {
            return 0;
        }

        public int FindLast(char element)
        {
            return 0;
        }

        public void Clear()
        {
        }

        public void Extend(MyList elements)
        {
        }
    }
}
