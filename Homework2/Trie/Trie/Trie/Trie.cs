namespace Trie;

/// <summary>
/// Data structure, which is a suspended tree with symbols on the edges, Trie.
/// </summary>
internal class Trie
{
    /// <summary>
    /// Initializes a new instance of the class.
    /// </summary>
    public Trie()
    {
        this._root = new();
        Size = 0;
    }

    private Node _root;

    /// <summary>
    /// Gets the size of the Trie, the number of strings in the Trie.
    /// </summary>
    public int Size { get; private set; }

    /// <summary>
    /// Trie node.
    /// </summary>
    private class Node
    {
        public Node()
        {
            this.Next = new();
            this.NumberWordsWithSamePrefix = 0;
            this.IsTerminal = false;
        }

        /// <summary>
        /// Gets collection of next nodes.
        /// </summary>
        public Dictionary<char, Node> Next { get; }

        /// <summary>
        /// Gets the number of words contained in this node.
        /// </summary>
        public int NumberWordsWithSamePrefix { get; set; }

        /// <summary>
        /// Gets information whether this node is a terminal
        /// </summary>
        public bool IsTerminal { get; set; }
    }

    /// <summary>
    /// Method to check if a string exists in a Trie.
    /// </summary>
    /// <param name="element"> String value. </param>
    /// <returns> True - this string is in Trie, False - this string isn't in Trie. </returns>
    /// <exception cref="ArgumentNullException"> String can't be null. </exception>
    public bool Contains(string? element)
    {
        if (element is null)
        {
            throw new ArgumentNullException(nameof(element), "Can't be null");
        }

        var currentNode = _root;
        foreach (var character in element)
        {
            if (!currentNode.Next.ContainsKey(character))
            {
                return false;
            }

            currentNode = currentNode.Next[character];
        }

        return currentNode.IsTerminal;
    }

    /// <summary>
    /// Method for adding a string to Trie.
    /// </summary>
    /// <param name="element"> String to add. </param>
    /// <returns> True - string added successfully, False - this string is already in Trie. </returns>
    /// <exception cref="ArgumentNullException"> String can't be null. </exception>
    public bool Add(string? element)
    {
        if (element is null)
        {
            throw new ArgumentNullException(nameof(element), "Can't be null.");
        }

        if (Contains(element))
        {
            return false;
        }

        var currentNode = _root;
        foreach (var character in element)
        {
            if (!currentNode.Next.ContainsKey(character))
            {
                currentNode.Next[character] = new Node();
            }

            currentNode.NumberWordsWithSamePrefix++;
            currentNode = currentNode.Next[character];
        }

        currentNode.NumberWordsWithSamePrefix++;
        Size++;
        return currentNode.IsTerminal = true;
    }

    /// <summary>
    /// Method for removing a string from a Trie.
    /// </summary>
    /// <param name="element"> String value. </param>
    /// <returns> True - the string was successfully deleted, False - the given string isn't in Trie.</returns>
    /// <exception cref="ArgumentNullException"> String can't be null. </exception>
    public bool Remove(string? element)
    {
        if (element is null)
        {
            throw new ArgumentNullException(nameof(element), "Can't be null.");
        }

        if (!Contains(element))
        {
            return false;
        }

        var currentNode = _root;
        foreach (var character in element)
        {
            currentNode.NumberWordsWithSamePrefix--;

            if (currentNode.Next[character].NumberWordsWithSamePrefix == 1)
            {
                currentNode.Next.Remove(character);
                Size--;
                return true;
            }

            currentNode = currentNode.Next[character];
        }

        currentNode.NumberWordsWithSamePrefix--;
        Size--;
        currentNode.IsTerminal = false;
        return true;
    }

    /// <summary>
    /// Method to get to know how many words starts with this prefix.
    /// </summary>
    /// <param name="prefix"> Prefix entered value. </param>
    /// <returns> Number of words which starts with this prefix. </returns>
    /// <exception cref="ArgumentNullException"> Prefix can't be null. </exception>
    public int HowManyWordsWithPrefix(string? prefix)
    {
        if (prefix is null)
        {
            throw new ArgumentNullException(nameof(prefix), "Can't be null");
        }

        var currentNode = _root;
        foreach (var character in prefix)
        {
            if (!currentNode.Next.ContainsKey(character))
            {
                return 0;
            }
            currentNode = currentNode.Next[character];
        }

        return currentNode.NumberWordsWithSamePrefix;
    }

    /// <summary>
    /// Method to print on user's screen a list of the actions.
    /// </summary>
    public static void PrintActions()
    {
        Console.WriteLine("""
            Read below what can I do:

            0 - Exit
            1 - Add an element
            2 - Remove an element
            3 - Check if the element contains in Trie
            4 - Get number of strings (words)
            5 - Get number of elements with prefix
            6 - Get this list of commands again

            """);
    }
}