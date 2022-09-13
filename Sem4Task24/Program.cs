// ============================================================
// #24 Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А. 
// Например: 7 -> 28; 4 -> 10; 8 -> 36
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

//РЕШЕНИЕ1 00:00:00.0172420
int VariantSumSimple(int numA)
{
    int sumOfNumbers = 0;
    for (int i = 1; i <= numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
}

//РЕШЕНИЕ2 по Гауссу 00:00:00.0000690 (аналитическое решение)
int VariantSumGauss(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}

int numberA = ReadData("Введите число А: ");
DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = VariantSumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до А равна (простой метод): " + res1);
PrintResult("Сумма чисел от 1 до А равна (метод Гаусса): " + res2);
