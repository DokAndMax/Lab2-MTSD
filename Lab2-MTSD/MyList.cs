namespace Lab2_MTSD
{
    public class MyList
    {
        private class Node
        {
            public char Value { get; set; }
            public Node Next { get; set; }
            public Node Prev { get; set; }

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

            Node? node = new(element);
            if (index == 0)
            {
                node.Next = head;
                head.Prev = node;
                head = node;
            }
            else if (index == count)
            {
                tail.Next = node;
                node.Prev = tail;
                tail = node;
            }
            else
            {
                Node? current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                node.Prev = current.Prev;
                node.Next = current;
                current.Prev.Next = node;
                current.Prev = node;
            }
            count++;

        }

        public char Delete(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException();
            }

            Node? current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            if (current.Prev is not null)
            {
                current.Prev.Next = current.Next;
            }
            else
            {
                head = current.Next;
            }

            if (current.Next is not null)
            {
                current.Next.Prev = current.Prev;
            }
            else
            {
                tail = current.Prev;
            }

            count--;
            return current.Value;
        }

        public void DeleteAll(char element)
        {
            Node? current = head;
            while (current is not null)
            {
                if (current.Value == element)
                {
                    if (current.Prev is not null)
                    {
                        current.Prev.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }

                    if (current.Next is not null)
                    {
                        current.Next.Prev = current.Prev;
                    }
                    else
                    {
                        tail = current.Prev;
                    }

                    count--;
                }
                current = current.Next;
            }
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
            MyList newList = new();

            Node? currentNode = head;

            while (currentNode != null)
            {
                newList.Append(currentNode.Value);
                currentNode = currentNode.Next;
            }

            return newList;
        }

        public void Reverse()
        {
            Node? currentNode = head;
            Node? tempNode = null;

            while (currentNode is not null)
            {
                tempNode = currentNode.Prev;
                currentNode.Prev = currentNode.Next;
                currentNode.Next = tempNode;
                currentNode = currentNode.Prev;
            }

            if (tempNode is not null)
            {
                head = tempNode.Prev;
            }
        }

        public int FindFirst(char element)
        {
            Node? currentNode = head;
            int index = 0;

            while (currentNode != null)
            {
                if (currentNode.Value == element)
                {
                    return index;
                }

                currentNode = currentNode.Next;
                index++;
            }

            return -1;
        }

        public int FindLast(char element)
        {
            Node? currentNode = tail;
            int index = count - 1;

            while (currentNode is not null)
            {
                if (currentNode.Value == element)
                {
                    return index;
                }

                currentNode = currentNode.Prev;
                index--;
            }

            return -1;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void Extend(MyList elements)
        {
            Node? currentNode = elements.head;

            while (currentNode is not null)
            {
                Append(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
    }
}
