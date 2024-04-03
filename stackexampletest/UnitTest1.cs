using stackexample;

namespace stackexampletest;

public class Tests
{
    IStack<double> stack;
    int capacity = 20;

    [SetUp]
    public void Setup()
    {
        stack = new stackexample.Stack<double>(capacity);
    }

    [Test]
    public void EmptyAtCreation()
    {
        Assert.That(stack.Height(), Is.EqualTo(0));
        Assert.Pass();
    }
}
