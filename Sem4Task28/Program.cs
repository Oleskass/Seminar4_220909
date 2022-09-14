// ============================================================
// #28 Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// Например: 4 -> 24; 5 -> 120
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

//вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//вариант1: логарифм
long CalculateFactorial(int num) //max 9 223 372 036 854 775 807
{
    long factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

//вариант2 (рекурсия - вызывает сам себя, будет на 9 семинаре)
long CalcData(int num)
{
    if (num == 1)
        return 1;
    return num * CalcData(num - 1);
}

int number = ReadData("Введите число: ");
long factorial = CalculateFactorial(number);
PrintResult("Произведение чисел от 1 до " + number + " равно: " + factorial);
long factorialRecursion = CalcData(number);
PrintResult("(рекурсия)Произведение чисел от 1 до " + number + " равно: " + factorialRecursion);