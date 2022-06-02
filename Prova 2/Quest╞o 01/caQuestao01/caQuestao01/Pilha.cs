using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao01
{
    public class Pilha<T>
    {
        private T[] storage;
        private int top;
        private int max_size;

        public int Count
        {
            get
            {
                return top + 1;
            }
            private set
            {
            }
        }
        public T Item(int index)
        {
            return storage[index];
        }
        public T[] Items
        {
            get
            {
                return storage;
            }
            private set { }
        }

        public Pilha(int size)
        {
            storage = new T[size];
            for (int i = 0; i < size; i++)
            {
                storage[i] = default(T);
            }
            max_size = size;
            top = -1;
        }

        public Pilha()
        {
            storage = new T[3];
            max_size = 3;
            top = -1;
        }

        public bool Add(T data)
        {
            if (top + 1 >= max_size)
                return false;
            top++;
            storage[top] = data;
            return true;
        }

        public T Pop()
        {
            if (top < 0)
                return default(T);
            top--;
            return storage[top + 1];
        }
    }
}
