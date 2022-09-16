// ===================================================================
// #29  Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов 
// ===================================================================

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

//создаётся рандомный массив с установлнными данными (длина 8, значения с 0 до 100)
int[] GenArray8() //метод возвращает, но не принимает
{
    int arrLength = 8;
    int[] array = new int[arrLength];
    Random rnd = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = rnd.Next(0, 101);
    }
    return array;
}

//*создаётся рандомный массив с заданными пользователем длиной и границами
int[] GenArrayBorder(int arrLength, int arrBorder1, int arrBorder2)
{
    int[] array = new int[arrLength];
    Random rnd = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = rnd.Next(arrBorder1, arrBorder2 + 1); //к addBorder2 прибавляю 1, чтобы ->
        // -> начало и конец значений массива соответствовало введённому пользователем
    }
    return array;
}

//вывод результата
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", "); //числа массива через запятую
    }
    Console.WriteLine(array[array.Length - 1]); //последнее число без запятой после
}

//вызов методов
PrintArray(GenArray8());
PrintArray(GenArrayBorder(arrLength: ReadData("Введите длину массива: "), arrBorder1:
ReadData("Введите начало значений массива: "), arrBorder2: ReadData("Введите конец значений массива: ")));