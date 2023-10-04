using System;

namespace Lab12Rez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        class Queue<T>
        {
            private T[] elements;
            private int capacity;
            public int Count { get; private set; } = 0;

            public Queue(int capacity)
            {
                this.capacity = capacity;
                elements = new T[capacity];
            }

            public void Enqueue(T elementToEnqueue)
            {
                if (Count==capacity)
                {
                    Console.WriteLine("este full");
                    return;
                }
                elements[Count] = elementToEnqueue;
                Count++;

            }

            public T Dequeue()
            {
                if (Count == 0)
                {
                    return default;
                }
                T result = elements[0];
                for (int i = 0; i < Count-1; i++)
                {
                    elements[i] = elements[i + 1];
                }
                Count--;
                return result;
            }

        }


    }
}
