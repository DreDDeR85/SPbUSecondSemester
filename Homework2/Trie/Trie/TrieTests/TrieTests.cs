namespace TrieTests;

public class TrieTests
{
    private static IEnumerable<TestCaseData> TrieCreation()
    {
        var trie = new Trie.Trie();
        yield return new TestCaseData(trie);
    }

    [Test, TestCaseSource(nameof(TrieCreation))]
    public void AddAndContains_NormalString_TrueAnswer(Trie.Trie trie)
    {
        trie.Add("cat");
        Assert.That(trie.Contains("cat"));
    }

    [Test, TestCaseSource(nameof(TrieCreation))]
    public void AddAndContainsAndRemove_NormalString_FalseAnswer(Trie.Trie trie)
    {
        trie.Add("cat");
        trie.Remove("cat");
        Assert.That(!trie.Contains("cat"));
    }

    [Test, TestCaseSource(nameof(TrieCreation))]
    public void AddAndContains_NormalString_FalseAnswer(Trie.Trie trie)
    {
        trie.Add("cat");
        Assert.That(!trie.Contains("dog"));
    }

    [Test, TestCaseSource(nameof(TrieCreation))]
    public void Add_NullString_ThrowException(Trie.Trie trie)
    {
        Assert.Throws<ArgumentNullException>(() => trie.Add(null), "Cannot add a null string");
    }

    [Test, TestCaseSource(nameof(TrieCreation))]
    public void Remove_NullString_ThrowException(Trie.Trie trie)
    {
        Assert.Throws<ArgumentNullException>(() => trie.Remove(null), "Cannot remove a null string");
    }

    [Test, TestCaseSource(nameof(TrieCreation))]
    public void Contains_NullString_ThrowException(Trie.Trie trie)
    {
        Assert.Throws<ArgumentNullException>(() => trie.Contains(null), "Cannot check on containsence a null string");
    }

    [Test, TestCaseSource(nameof(TrieCreation))]
    public void AddRemoveAndContains_ALotOfStrings_CorrectSize(Trie.Trie trie)
    {
        trie.Add("cup");
        trie.Add("cat");
        trie.Add("cataclysm");
        trie.Add("bat");
        trie.Add("cupidon");
        trie.Remove("cupidon");

        var expected = 4;
        Assert.That(trie.Size, Is.EqualTo(expected));
    }

    [Test, TestCaseSource(nameof(TrieCreation))]
    public void AddRemoveContainsAndHowManyWordsWithPrefix_ALotOfStrings_CorrectAnswer(Trie.Trie trie)
    {
        trie.Add("cup");
        trie.Add("cat");
        trie.Add("cataclysm");
        trie.Add("bat");
        trie.Add("cupidon");
        trie.Remove("cupidon");

        var expected = 2;
        Assert.That(trie.HowManyWordsWithPrefix("cat"), Is.EqualTo(expected));
    }

    [Test, TestCaseSource(nameof(TrieCreation))]
    public void AddRemoveContainsAndHowManyWordsWithPrefix_ALotOfStrings_ZeroAnswer(Trie.Trie trie)
    {
        trie.Add("cup");
        trie.Add("cat");
        trie.Add("cataclysm");
        trie.Add("bat");
        trie.Add("cupidon");
        trie.Remove("cupidon");

        var expected = 0;
        Assert.That(trie.HowManyWordsWithPrefix("d"), Is.EqualTo(expected));
    }

    [Test, TestCaseSource(nameof(TrieCreation))]
    public void AddRemoveContains_ALotOfStrings_CorrectAnswer(Trie.Trie trie)
    {
        trie.Add("cup");
        trie.Add("cat");
        trie.Add("cataclysm");
        trie.Add("bat");
        trie.Add("cupidon");
        trie.Remove("cupidon");

        Assert.That(trie.Contains("cat"));
    }

    [Test, TestCaseSource(nameof(TrieCreation))]
    public void HowManyWordsWith_NullString_ThrowException(Trie.Trie trie)
    {
        Assert.Throws<ArgumentNullException>(() => trie.HowManyWordsWithPrefix(null), "Cannot check on quantity with a null string");
    }
}
