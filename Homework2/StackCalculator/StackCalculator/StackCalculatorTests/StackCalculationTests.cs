namespace StackCalculatorTests;

using StackCalculator;

public class StackCalculatorTests
{
    private static IEnumerable<TestCaseData> Stacks => new TestCaseData[]
    {
        new TestCaseData(new StackCalculator(new StackOnArray())),
        new TestCaseData(new StackCalculator(new StackOnList())),
    };

    [TestCaseSource(nameof(Stacks))]
    public void CalculateExpression_CorrectExpression_CorrectAnswerReturned(StackCalculator stackCalculator)
    {
        var expression = "7 3 + 2 *";
        var expected = 20;

        var actual = stackCalculator.CalculateExpression(expression);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCaseSource(nameof(Stacks))]
    public void CalculateExpression_FractionalNumbers_ExceptionReturned(StackCalculator stackCalculator)
    {
        var expression = "7,5 3,8 + 2,1 *";

        Assert.Throws<ArgumentException>(() => stackCalculator.CalculateExpression(expression));
    }

    [TestCaseSource(nameof(Stacks))]
    public void CalculateExpression_IncorrectExpression1_ExceptionReturned(StackCalculator stackCalculator)
    {
        var expression = "7 3 + 2 * 1";

        Assert.Throws<ArgumentException>(() => stackCalculator.CalculateExpression(expression));
    }

    [TestCaseSource(nameof(Stacks))]
    public void CalculateExpression_IncorrectExpression2_ExceptionReturned(StackCalculator stackCalculator)
    {
        var expression = "7 V + 2 *";

        Assert.Throws<ArgumentException>(() => stackCalculator.CalculateExpression(expression));
    }

    [TestCaseSource(nameof(Stacks))]
    public void CalculateExpression_IncorrectExpression3_ExceptionReturned(StackCalculator stackCalculator)
    {
        var expression = "7 3 + 2 %";

        Assert.Throws<ArgumentException>(() => stackCalculator.CalculateExpression(expression));
    }

    [TestCaseSource(nameof(Stacks))]
    public void CalculateExpression_EmptyExpression_ExceptionReturned(StackCalculator stackCalculator)
    {
        var expression = string.Empty;

        Assert.Throws<ArgumentNullException>(() => stackCalculator.CalculateExpression(expression));
    }

    [TestCaseSource(nameof(Stacks))]
    public void CalculateExpression_NullExpression_ExceptionReturned(StackCalculator stackCalculator)
    {
        string? expression = null;

        Assert.Throws<ArgumentNullException>(() => stackCalculator.CalculateExpression(expression));
    }

    [TestCaseSource(nameof(Stacks))]
    public void CalculateExpression_DivisionByZeroExpression_DivideByZeroExceptionReturned(StackCalculator stackCalculator)
    {
        var expression = "7 3 + 0 /";

        Assert.Throws<DivideByZeroException>(() => stackCalculator.CalculateExpression(expression));
    }
}