namespace StackCalculator;

/// <summary>
/// Stack realization by using a linked list.
/// </summary>
public class StackOnList : IStack
{
    public StackOnList()
    {
        stack = new LinkedList<int>();
    }

    private LinkedList<int> stack;

    /// <inheritdoc/>
    public void Push(int value)
    {
        stack.AddFirst(value);
    }

    /// <inheritdoc/>
    public bool IsEmpty()
    {
        return stack.First == null;
    }

    /// <inheritdoc/>
    public int Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Cannot pop element from empty stack.");
        }

        int result = stack.First();
        stack.RemoveFirst();

        return result;
    }
}