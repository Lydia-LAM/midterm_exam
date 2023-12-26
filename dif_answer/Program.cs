using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        string[] newArray = FilterStrings(originalArray);
        Console.WriteLine("Новый массив строк длиной <= 3 символам:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }

        Console.ReadLine();
    }
    static string[] FilterStrings(string[] originalArray)
    {
        int count = 0;
        foreach (string str in originalArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }
        string[] newArray = new string[count];
        int index = 0;
        foreach (string str in originalArray)
        {
            if (str.Length <= 3)
            {
                newArray[index] = str;
                index++;
            }
        }
        return newArray;
    }
}