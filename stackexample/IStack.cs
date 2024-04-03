using System;
namespace stackexample
{
	public interface IStack<T>
	{
		T Top();

		void Pop();

		void Push(T value);

		void Clear();

		int Height();

		int Capacity();
	}
}

