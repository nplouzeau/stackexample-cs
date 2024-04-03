namespace stackexample
{
    /// <summary>
    /// A simple definition of a classical stack structure.
    /// </summary>
    /// <typeparam name="T">The type of the values in the stack</typeparam>
    public interface IStack<T>
    {
        /// <summary>
        /// Indicates if the stack contains values.
        /// </summary>
        /// <returns>true iff there are values inside</returns>
        bool IsEmpty();

        /// <summary>
        /// Provides the number of values stored in the stack.
        /// </summary>
        /// <returns></returns>
        int Height();


        T Top();

        void Pop();

        void Push(T value);

        void Clear();

        int Capacity();
    }
}

