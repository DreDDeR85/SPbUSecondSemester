namespace StackCalculator;


/// <summary>
/// Stask realization by using an array.
/// </summary>
public class StackOnArray : IStack
{
    public StackOnArray()
    {
        stack = new List<int>();
    }

    private List<int> stack;

    /// <inheritdoc/>
    public void Push(int value)
    {
        stack.Add(value);
    }

    /// <inheritdoc/>
    public bool IsEmpty()
    {
        return stack.Count == 0;
    }

    /// <inheritdoc/>
    public int Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Cannot pop element from empty stack.");
        }

        var upElement = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        return upElement;
    }
}