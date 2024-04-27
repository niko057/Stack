using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class MyStack<T>
    {
        private T[] _items;
        private int _top;

        public MyStack(int size)
        {
            _items = new T[size];
            _top = -1;
        }

        public void Push(T item)
        {
            if (_top == _items.Length - 1)
            {
                Array.Resize(ref _items, _items.Length * 2);
            }

            _top++;
            _items[_top] = item;
        }

        public T Pop()
        {
            if (_top == -1)
            {
                Console.WriteLine("Stack is empty");
            }

            T poppedItem = _items[_top];
            _top--;
            return poppedItem;
        }

        public T Peek()
        {
            if (_top == -1)
            {
                Console.WriteLine("Stack is empty");
            }

            return _items[_top];
        }
    }
}
