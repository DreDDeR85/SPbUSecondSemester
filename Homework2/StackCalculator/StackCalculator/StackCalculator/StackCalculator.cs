﻿namespace StackCalculator;

/// <summary>
/// Class for calculation the result of expression in polish postfix form.
/// </summary>
public class StackCalculator
{
    public StackCalculator(IStack stack)
    {
        this._stack = stack;
    }

    private readonly IStack _stack;

    private static bool IsZero(int number)
    {
        return Math.Abs(number) < 0.0001;
    }

    private void Operations(string sign)
    {
        int firstElement = 0;
        int secondElement = 0;

        try
        {
            firstElement = _stack.Pop();
            secondElement = _stack.Pop();
        }
        catch (InvalidOperationException)
        {
            throw new ArgumentException("Incorrect expression");
        }

        switch (sign)
        {
            case "+":
                _stack.Push(firstElement + secondElement);
                break;

            case "-":
                _stack.Push(firstElement - secondElement);
                break;

            case "*":
                _stack.Push(firstElement * secondElement);
                break;

            case "/":
                if (IsZero(firstElement))
                {
                    throw new DivideByZeroException();
                }

                _stack.Push(firstElement / secondElement);
                break;
        }
    }

    /// <summary>
    /// A method for calculation the result of expression in polish postfix form.
    /// </summary>
    /// <param name="expression"> Expression in reverse polish notation. </param>
    /// <returns> Result of the expression. </returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public int CalculateExpression(string? expression)
    {
        if (expression == null)
        {
            throw new ArgumentNullException(nameof(expression), "cannot be null.");
        }

        if (expression == string.Empty)
        {
            throw new ArgumentNullException(nameof(expression), "cannot be empty.");
        }

        string operations = "*/-+";
        foreach (var element in expression.Split(" ", StringSplitOptions.RemoveEmptyEntries))
        {
            if (operations.Contains(element))
            {
                Operations(element);
            }
            else
            {
                int number = 0;
                if (!int.TryParse(element, out number))
                {
                    throw new ArgumentException("Incorrect expression.");
                }
                _stack.Push(number);
            }
        }

        int result = 0;
        try
        {
            result = _stack.Pop();
        }
        catch (InvalidOperationException)
        {
            throw new ArgumentException("Incorrect expression.");
        }

        if (!_stack.IsEmpty())
        {
            throw new ArgumentException("Incorrect expression.");
        }

        return result;
    }
}