Console.Clear();

string[] arrayA = new string[10];
string a = "";

Console.WriteLine("Введите значения элементов массива строк (до десяти элементов).");
FillArray(arrayA);

string[] FillArray(string[] arr) // метод задания значений
{
    for (int i = 0; i < arrayA.Length; i++)
    {
        Console.WriteLine($"Введите значение {i + 1} элемента. Для досрочного завершения заполнения введите STOP");
        a = Console.ReadLine()!;
        if (a == "STOP")
        {
            break;
        }
        arrayA[i] = a;
    }
    return arr;
}

Console.WriteLine("Вы ввели следующий массив");
PrintArray(arrayA);

void PrintArray (string[] arr) // метод распечатки массивов без вывода пустых значений
{
    for (int i = 0; i < arr.Length; i++)
    {
        {
            if (arr[i] == null)
            {
                Console.Write("]");
                break;
            }
            else if (i == 0) { Console.Write($"[{arrayA[i]}"); }
            else if (i == arrayA.Length - 1) { Console.Write($"{arrayA[i]}]"); }
            else if (i != arrayA.Length - 1) { Console.Write($", {arrayA[i]}"); }
        }
    }
}

Console.WriteLine("Вы ввели следующий массив");
PrintArray(arrayA);
