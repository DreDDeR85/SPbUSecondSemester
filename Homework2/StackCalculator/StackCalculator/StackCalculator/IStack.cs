namespace StackCalculator;

///<summary>
/// Stack is a last in - first out container for real values.
/// </summary>
public interface IStack
{
    ///<summary>
    /// Add element in stack.
    /// </summary>
    /// <param name="value"> Value to add.</param>
    public void Push(int value);


    /// <summary>
    /// Returns and removes an element from the top of the stack.
    /// </summary>
    /// <returns> Top element from the stack.</returns>
    /// <exception cref="InvalidOperationException"> Not be able to pop an element from empty stack.</exception>
    public int Pop();


    /// <summary>
    /// Checking for stack empty.
    /// </summary>
    /// <returns> True, when the stack is empty, and False, if stack contains at least one element</returns>
    public bool IsEmpty();
}