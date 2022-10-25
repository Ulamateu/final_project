int size = 5;
string[] array = new string[size];

Console.WriteLine("Введите с клавиатуры любое количество символов 5 раз через enter (допустимы как буквы, так и цифры): ");
FillArray(array);
Console.Clear();
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Строковый массив с элементами меньше или равно 3-х: ");
Sorted(array);

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
  
}
void Sorted(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
            Console.Write(array[i] + " ");
        }
    }
    if (count == 0)
        {
           Console.WriteLine();
           Console.Write("В данном массиве нет элементов меньше или равном 3-м!"); 
        }
}
