using System.Linq;

class Programm
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();

        if (line != null)
        {
            string[] words = SplitText(line); //Разделение предложения в массив слов
            Console.ReadKey();

            ShiftWords(words); //Перенос слов на строку
            Console.ReadKey();

            ReplaceWords(words); //Замена слов местами и соединение
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Разделение предложения в массив слов
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    static string[] SplitText(string text)
    {
        string[] words = text.Split(" ");
        return words;
    }

    /// <summary>
    /// Перенос слов на строку
    /// </summary>
    /// <param name="shiftwords"></param>
    /// <returns></returns>
    static string[] ShiftWords(string[] shiftwords)
    {
        foreach (string word in shiftwords)
        {
            Console.WriteLine($" \n{word}");
        }
        return shiftwords;
    }

    /// <summary>
    /// Замена слов местами и соединение
    /// </summary>
    /// <param name="replacewords"></param>
    /// <returns></returns>
    static string ReplaceWords(string[] replacewords)
    {
        string[] words = replacewords;
        Array.Reverse(words);
        string joinedwords = string.Join(" ", words);

        Console.WriteLine($"{joinedwords}");

        return joinedwords;
    }
}