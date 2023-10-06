using static System.Console;

WriteLine("I can encode and decode a text using the Burrows-Wheeler transform.");
Write("What you wanna to do? [encode/decode/exit]: ");

string? action = "";

while (action != "exit")
{
    action = Console.ReadLine();
    if (action == null)
    {
        throw new ArgumentNullException("Text entered cannot be null.");
    }
    action = action.ToLower();

    switch (action)
    {
        case "encode":
            Console.Write("Give me a text to encode: ");
            string? textForEncode = Console.ReadLine();
            while (string.IsNullOrEmpty(textForEncode))
            {
                Console.Write("Text for encode cannot be null. Enter again, please: ");
                textForEncode = Console.ReadLine();
            }

            (string encodedText, int index) resultEncode = BWT.BWT.Encode(textForEncode);
            Console.WriteLine($"Converted text: {resultEncode.encodedText}\nLine end index: {resultEncode.index}");
            Write("What you wanna to do next? [encode/decode/exit]: ");
            break;

        case "decode":
            Console.Write("Give me a text to decode: ");
            string? textForDecode = Console.ReadLine();
            while (string.IsNullOrEmpty(textForDecode))
            {
                Console.Write("Text for decode cannot be null. Enter again, please: ");
                textForDecode = Console.ReadLine();
            }
            Console.Write("Give me a index of encoding (number of the original row in the sorted matrix)\nof entered before text: ");
            int index = -1;
            while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= textForDecode.Length)
            {
                Console.WriteLine("This index is a non-negative integer number lower than length of the entered before text.");
                Console.Write("Please, try to enter index again: ");
            }

            string resultDecode = BWT.BWT.Decode(textForDecode, index);

            Console.WriteLine($"Result of decoding is: {resultDecode}");
            Write("What you wanna to do next? [encode/decode/exit]: ");
            break;

        case "exit":
            Console.WriteLine("Au revoir!");
            break;

        default:
            Console.Write("Please, enter [encode/decode/exit] and nothing else: ");
            break;
    }
}