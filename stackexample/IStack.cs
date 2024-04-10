using System.Runtime.Serialization;

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
        /// <returns>true if and only if there are no values in the stack</returns>
        bool IsEmpty();

        /// <summary>
        /// Provides the number of values stored in the stack.
        /// </summary>
        /// <returns></returns>
        int Height();

        /// <summary>
        /// Provides the value at the top of the stack,
        /// i.e. the last one that was pushed.
        /// </summary>
        /// <returns>top value of the stack</returns>
        T Top();

        /// <summary>
        /// Removes the top value of the stack.
        /// </summary>
        void Pop();

        /// <summary>
        /// Adds a new value as the new top of the stack, if the stack is not full.
        /// </summary>
        /// <param name="value">the value to be add</param>
        /// <exception cref="CapacityExceededException">Throw CapacityExceedException
        /// if the stack is full: IsFull() returns true
        /// </exception>
        void Push(T value);

        /// <summary>
        /// Removes of values in the stack, making it empty.
        /// </summary>
        void Clear();

        /// <summary>
        /// Provides the maximum number of values that can be in the stack.
        /// </summary>
        /// <returns>the capacity of the stack</returns>
        int Capacity();

        /// <summary>
        /// Indicates if the stack cannot accept more values
        /// </summary>
        /// <returns>true if and only if there is no space left in the stack</returns>
        bool IsFull();
    }
    [Serializable]
    public class CapacityExceededException : Exception
    {
        public CapacityExceededException()
        {
        }

        public CapacityExceededException(string? message) : base(message)
        {
        }

        public CapacityExceededException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CapacityExceededException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    public class EmptyStackException : Exception
    {
        public EmptyStackException()
        {
        }

        public EmptyStackException(string? message) : base(message)
        {
        }

        public EmptyStackException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmptyStackException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

