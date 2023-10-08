namespace ParseTree;

/// <summary>
/// Implementation of the "substraction" operation
/// </summary>
internal class Substraction : Operation
{
    /// <summary>
    /// The constructor of the Substraction, with the addition of two operands.
    /// </summary>
    /// <param name="leftChild"> Left operand. </param>
    /// <param name="rightChild"> Right operand. </param>
    public Substraction(IParseTreeElement leftChild, IParseTreeElement rightChild) : base(leftChild, rightChild)
    {
    }

    /// <summary>
    /// Computing the substraction operation.
    /// </summary>
    /// <returns> Result of calculation. </returns>
    public override double Calculate() => LeftChild.Calculate() - RightChild.Calculate();

    /// <summary>
    /// Output like: "(- [left_value] [right_value])"
    /// </summary>
    public override void Print()
    {
        Console.Write("( - ");
        base.Print();
    }
}