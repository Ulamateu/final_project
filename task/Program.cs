// Вариант 1 решения этой задачи.
int size = 5;
string[] array = new string[size];
Console.WriteLine("Введите с клавиатуры любое количество символов 5 раз через enter (допустимы как буквы, так и цифры): ");
FillArray(array);
Console.Clear();
PrintArray(array);
int len = SecondSize(array);
Console.WriteLine();
Console.WriteLine("Строковый массив с элементами меньше или равно 3-х: ");
TransferElements(array, len);
void FillArray(string[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = Console.ReadLine()!;
    }
}
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
int SecondSize(string[] array)
{
    int leng = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            leng++;
        }
    }
    return leng;
}
void TransferElements(string[] array, int leng)
{
    string[] array2 = new string[leng];
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[i] = array[i];
            Console.Write(array2[i] + " ");
        }
    }
    Console.Write("]");
}

// Вариант 2 решения этой задачи.
// int size = 5;
// string[] array = new string[size];
// Console.WriteLine("Введите с клавиатуры любое количество символов 5 раз через enter (допустимы как буквы, так и цифры): ");
// FillArray(array);
// Console.Clear();
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine("Строковый массив с элементами меньше или равно 3-х: ");
// TranferElements(array);
// void FillArray(string[] array)
// {
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Console.ReadLine()!;
//     }
// }
// void PrintArray(string[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }
// void TranferElements(string[] array)
// {
//     int count = 0;
//     for (int i = 0; i < size; i++)
//     {
//         if (array[i].Length <= 3)
//         {
//             count++;
//         }
//     }
//     string[] array2 = new string[count];
//     Console.Write("[ ");
//     for (int i = 0; i < size; i++)
//     {
//         if (array[i].Length <= 3)
//         {
//             count++;
//             array2[i] = array[i];
//             Console.Write(array2[i] + " ");
//         }
//     }
//      Console.Write("]");
//     if (count == 0)
//     {
//         Console.WriteLine();
//         Console.Write("В данном массиве нет элементов меньше или равном 3-м!"); - если нужно, можно включить, как доп сообщение( строка 103-107).
//     }
//  }
 