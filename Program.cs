Console.Clear();

string[] arrayA =
 {
    "ad#", 
    "b1",
    "5cccc",
    "Roar",
    "end"
};

Console.Write("Исходный массив: ");
PrintArray(arrayA);

Console.Write("\nИз изначально введенного массива массив с длиной строк меньше трех символов:");

string[] arrayB = LessThanThreeArray(arrayA);
PrintArray(arrayB);

void PrintArray (string[] arr) // метод распечатки массивов без вывода пустых значений
{
    for (int i = 0; i < arr.Length; i++)
    {
        {
            if (arr[i] == null && i == 0) //проверка на первый пустой элемент
            {
                Console.Write("[]"); 
                break;
            }
            if (arr[i] == null)
            {
                Console.Write("]"); //проверка на пустой элемент для закрытия массива
                break;
            }
            else if (i == 0) { Console.Write($"[{arr[i]}"); } //печатаем красиво первый символ массива
            else if (i == arr.Length - 1) { Console.Write($"{arr[i]}]"); } //печатаем красиво последний символ массива
            else if (i != arr.Length - 1) { Console.Write($", {arr[i]}"); } //печатаем значения между первым и последним
        }
    }
}

string[] LessThanThreeArray (string[] arr) // метод распечатки подходящих значений массива меньше трех символов от исходного массива
{
    int i = 0;
    string[] result = new string [arr.Length];
    
    
    foreach (var item in arr)
    {
            if (item.Length <= 3)
            {
                result[i] = item;
                i++;
            }
    }
    return result;
}
