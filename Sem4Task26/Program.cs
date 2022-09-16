// ============================================================
// #26 Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// Пример: 456 -> 3; 78 -> 2; 89126 -> 5
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

//вариант1: длина строки //123456789 00:00:00.0162170
int QuantityNum(int num)
{
    string numString = num.ToString();
    return numString.Length;
}


//вариант2: вычисления //123456789 00:00:00.0001010
int DigitCount(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += 1;
        num = num / 10;
    }
    return sum;
}

//вариант3: логарифм //123456789 00:00:00.0001940
int DigitCountLog(int num)
{
    return (int)(Math.Log10(num) + 1);
}

int number = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int numberOfDigits = QuantityNum(number);
Console.WriteLine(DateTime.Now - d1);

PrintResult("Количество цифр в числе (длина строки): " + numberOfDigits);

DateTime d2 = DateTime.Now;
int numberOfDigits2 = DigitCount(number);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Количество цифр в числе (вычисления): " + numberOfDigits2);

DateTime d3 = DateTime.Now;
int numberOfDigits3 = DigitCountLog(number);
Console.WriteLine(DateTime.Now - d3);

PrintResult("Количество цифр в числе (логарифм): " + numberOfDigits3);