namespace BWTTests;
public class Tests
{
    [Test]
    public void Encode_UsualString_UsualResult()
    {
        var enteredString = ".BANANA.";
        var expectedString = ("BNN.AA.A", 6);

        var result = BWT.BWT.Encode(enteredString);

        Assert.That(result, Is.EqualTo(expectedString));
    }

    [Test]
    public void Encode_EmptyString_ZeroResult()
    {
        var enteredString = "";
        var expectedString = ("", 0);

        var result = BWT.BWT.Encode(enteredString);

        Assert.That(result, Is.EqualTo(expectedString));
    }

    [Test]
    public void Decode_UsualString_UsualResult()
    {
        var enteredString = "BNN.AA.A";
        var enteredNumber = 6;
        var expectedString = ".BANANA.";

        var result = BWT.BWT.Decode(enteredString, enteredNumber);

        Assert.That(result, Is.EqualTo(expectedString));
    }

    [Test]
    public void Decode_EmptyString_ExceptionResult()
    {
        var enteredString = "";
        var enteredNumber = 0;

        Assert.Throws<ArgumentException>(() => BWT.BWT.Decode(enteredString, enteredNumber));
    }
}