namespace StackCalculator;


/// <summary>
/// Stask realization by using an array.
/// </summary>
public class StackOnArray : IStack
{
    public StackOnArray()
    {
        stack = new List<double>();
    }

    private List<double> stack;

    /// <inheritdoc/>
    public void Push(double value)
    {
        stack.Add(value);
    }

    /// <inheritdoc/>
    public bool IsEmpty()
    {
        return stack.Count == 0;
    }

    /// <inheritdoc/>
    public double Pop()
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