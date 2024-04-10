using stackexample;

namespace stackexampletest;

[TestFixture]
public class Tests
{
    IStack<double> stack;
    readonly int capacity = 3;

    /// <summary>
    /// Creates a new, clean and empy stack for each test case below.
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
    public void CheckCapacity()
    {
        Assume.That(capacity, Is.GreaterThanOrEqualTo(1));
        Assert.That(stack.Capacity(), Is.EqualTo(capacity));
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

    [Test]
    public void PushTwoValuesCheckTopThenOnePop()
    {
        stack.Push(1.0);
        stack.Push(2.0);
        Assert.That(stack.Top(), Is.EqualTo(2.0));
        stack.Pop();
        Assert.That(stack.Top(), Is.EqualTo(1.0));
    }

    [Test]
    public void PushBeyondCapacity()
    {
        Assert.That(() =>
        {
            for (int i = 0; i <= capacity; i++)
            {
                stack.Push(i);
            }
        }, Throws.TypeOf<CapacityExceededException>());
    }

    [Test]
    public void PopOnAnEmptyStack()
    {
        Assert.That(() => stack.Pop(), Throws.TypeOf<EmptyStackException>());
    }
}
