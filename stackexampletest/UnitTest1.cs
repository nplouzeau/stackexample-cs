using stackexample;

namespace stackexampletest;

public class Tests
{
    IStack<double> stack;
    int capacity = 20;

    /// <summary>
    /// Creates a new, clen and empy stack for each test case below.
    /// </summary>
    [SetUp]
    public void Setup()
    {
        stack = new stackexample.Stack<double>(capacity);
    }

    [Test]
    public void EmptyAtCreation()
    {
        Assert.That(stack.Height(), Is.EqualTo(0));
        Assert.That(stack.IsEmpty());
    }

    [Test]
    public void PushOneValue()
    {
        stack.Push(10.0);
        Assert.That(stack.Top(), Is.EqualTo(10.0));
    }

    [Test]
    public void PushThenPop()
    {
        stack.Push(10.0);
        stack.Pop();
        Assert.That(stack.Height(), Is.EqualTo(0));
    }
}
