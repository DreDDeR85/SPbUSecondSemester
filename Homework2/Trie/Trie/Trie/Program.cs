using static System.Console;

WriteLine("I am a data structure for storing a set of strings. They call me Trie.\n");
Trie.Trie.PrintActions();

int action = 0;
var trie = new Trie.Trie();
var isContinue = true;
while (isContinue)
{
    Write("Enter the command numer: ");
    while (!int.TryParse(ReadLine(), out action) || action < 0 || action > 6)
    {
        WriteLine("Incorrect input! Enter only one natural number between 0 and 6.");
        Write("Try again: ");
    }
    string? str = "";

    switch (action)
    {
        case 0:
            WriteLine("Au revoir!");
            isContinue = false;
            break;

        case 1:
            WriteLine("Enter a string: ");
            str = ReadLine();

            WriteLine(trie.Add(str) ? "String added successfully!" : "This string is already in Trie.");
            break;

        case 2:
            Write("Enter a string: ");
            str = ReadLine();

            WriteLine(trie.Remove(str) ? "String removed successfully!" : "This string is not in Trie.");
            break;

        case 3:
            Write("Enter a string: ");
            str = ReadLine();

            WriteLine(trie.Contains(str) ? "Yes, this string is in Trie!" : "No. this string isn't in Trie.");
            break;

        case 4:
            WriteLine($"Number of strings: {trie.Size}");
            break;

        case 5:
            Write("Enter a prefix: ");
            str = ReadLine();

            WriteLine($"Number of lines which starts with \"{str}\": {trie.HowManyWordsWithPrefix(str)}");
            break;

        case 6:
            Trie.Trie.PrintActions();
            break;
    }

}