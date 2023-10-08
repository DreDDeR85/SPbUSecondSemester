namespace StackCalculator;

/// <summary>
/// Stack realization by using a linked list.
/// </summary>
public class StackOnList : IStack
{
    public StackOnList()
    {
        stack = new LinkedList<double>();
    }

    private LinkedList<double> stack;

    /// <inheritdoc/>
    public void Push(double value)
    {
        stack.AddFirst(value);
    }

    /// <inheritdoc/>
    public bool IsEmpty()
    {
        return stack.First == null;
    }

    /// <inheritdoc/>
    public double Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Cannot pop element from empty stack.");
        }

        double result = stack.First();
        stack.RemoveFirst();

        return result;
    }
}