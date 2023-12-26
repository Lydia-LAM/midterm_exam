using System;

class Program
{
    static void Main()
    {
        string[] originalArray = { "horse", "cat", "dog", "mice", "ant" };
        string[] newArray = new string[0];
        foreach (string str in originalArray)
        {
            if (str.Length <= 3)
            {
                Array.Resize(ref newArray, newArray.Length + 1);
                newArray[newArray.Length - 1] = str;
            }
        }
        Console.Write("Новый массив строк из символов длиной <= 3: ");
        foreach (string str in newArray)
        {
            Console.Write($"{str}, ");
        }
    }
}