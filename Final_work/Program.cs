/* Проверочная работа
Задача: Написать программу, которая из сформированного массива строк 
содержащих символы и числа создать массив из строк, в который попадут 
только символы, не являющиеця цифрами. 
Входные данные можно получить путём ввода с клавиатуры, 
но лучше сделать автогенерацию данных. 
При решении не использовать "читерство".
*/

string autoGenerationText()
{
    string result = "";
    int numberCharacters = new Random().Next(5, 15);
    while (result.Length < numberCharacters)
    {
        int chKod = new Random().Next(48, 123);
        if (chKod >= 48 && chKod <= 57 ||
            chKod >= 65 && chKod <= 90 ||
            chKod >= 97 && chKod <= 122
           ) result += (char)chKod;
    }

    return result;
}

string[] StrArray(int size)
{
    string[] strResult = new string[size];
    for (int i = 0; i < size; i++)
    {
        strResult[i] = autoGenerationText();
    }
    return strResult;
}

string[] RemovingNumbers(string[] arr)
{
    int size = arr.Length;
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        string newString = "";
        foreach (char item in arr[i])
        {
            if ((int)item > 57)
            {
                newString += Convert.ToString((char)item);
            }
        }
        result[i] = newString;
    }
    return result;
}

void printDigitColor(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        foreach (char item in arr[i])
        {
            if ((int)item < 58)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(item);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write(item);
            }
        }
        Console.Write(" ");
    }
}

Console.Clear();
string[] array = StrArray(3);
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("Массив строк содержащий цифры:");
Console.ForegroundColor = ConsoleColor.White;
printDigitColor(array);
Console.Write("\n\n");
Console.Write(String.Join(" ", RemovingNumbers(array)));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("\nМассив строк после удаления цифр");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();



