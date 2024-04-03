using System;
namespace stackexample
{
	public class Stack<T> : IStack<T>
	{
        private T[] values;

        private int top;


		public Stack(int capacity)
		{
            values = new T[capacity];
            top = -1;
		}

        public int Capacity()
        {
            return values.Length;
        }

        public void Clear()
        {
            top = -1;
        }

        public int Height()
        {
            return top + 1;
        }

        public bool IsEmpty()
        {
            return Height() == 0;
        }

        public void Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T value)
        {
            throw new NotImplementedException();
        }

        public T Top()
        {
            throw new NotImplementedException();
        }
    }
}

