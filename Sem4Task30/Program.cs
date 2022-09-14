// ============================================================
// #30 Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в случайном 
// порядке. Например: [1,0,1,1,0,1,0,0]
// ============================================================

//чтение данных пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

//создаётся рандомный массив с заданной длиной
int[] GenArray(int arrLength)
{
    int[] array = new int[arrLength];
    Random rnd = new Random();
    for (int i = 0; i < arrLength - 1; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

//вывод результата
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

PrintArray(GenArray(ReadData("Введите длину массива: ")));

// //развернуто то же самое
// int arrLength = ReadData("Введите длину массива: ");
// int[] array = GenArray(arrLength);
// PrintArray(array);