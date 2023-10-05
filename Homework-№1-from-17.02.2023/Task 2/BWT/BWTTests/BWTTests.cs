namespace BWTTests;
public class Tests
{
    [Test]
    public void Encode_UsualString_UsualResult()
    {
        var enteredString = ".BANANA.";
        var expectedString = ("A.NNB.AA", 1);

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
        var enteredString = "A.NNB.AA";
        var enteredNumber = 1;
        var expectedString = ".BANANA.";

        var result = BWT.BWT.Decode(enteredString, enteredNumber);

        Assert.That(result, Is.EqualTo(expectedString));
    }

    [Test]
    public void Decode_EmptyString_ExceptionResult()
    {
        var enteredString = "";
        var enteredNumber = 0;

        Assert.Throws<ArgumentNullException>(() => BWT.BWT.Decode(enteredString, enteredNumber));
    }
}