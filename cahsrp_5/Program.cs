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

            ReplaceWords(words); //Замена слов местами
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
    static string ShiftWords(string[] shiftwords)
    {
        foreach (string word in shiftwords)
        {
            Console.WriteLine($" \n{word}");
        }
        return shiftwords[shiftwords.Length - 1];
    }

    /// <summary>
    /// Замена слов местами
    /// </summary>
    /// <param name="replacewords"></param>
    /// <returns></returns>
    static string ReplaceWords(string[] replacewords)
    {
        string[] strings = new string[replacewords.Length];
        int s = 1;

        for (int i = 0; i < replacewords.Length; i++)
        {
            strings[i] = replacewords[replacewords.Length - s];
            s++;
        }

        foreach (string word in strings)
        {
            Console.WriteLine($" \n{word}");
        }

        return strings[strings.Length - 1];
    }
}