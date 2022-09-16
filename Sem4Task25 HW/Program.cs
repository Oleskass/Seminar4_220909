// ======================================================================
// #25  Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Например: 3, 5 -> 243 (3⁵); 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень
// ======================================================================

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

//решение 1 //3^5 00:00:00.0165000 (отдельно запускала каждую)
long Pow(int num, int degree)
{
    long numDeg = 1;
    for (int i = 1; i <= degree; i++)
    {
        numDeg = numDeg * num;
    }
    return numDeg;
}

//решение 2 метод Math.Pow //3^5 00:00:00.0162090 (отдельно запускала каждую)
long PowMath(int num, int degree)
{
    long numDeg = (long)Math.Pow(num, degree); //
    return numDeg;
}

//программа
int num = ReadData("Ваше число: ");
int degree = ReadData("В какую степень возвести? ");

//DateTime d1 = DateTime.Now;
long res = Pow(num, degree);
//Console.WriteLine(DateTime.Now - d1);

//DateTime d2 = DateTime.Now;
long resMath = PowMath(num, degree);
//Console.WriteLine(DateTime.Now - d2);

PrintResult($"Число {num} в степени {degree} равно {res}"); //вывод результата 1
PrintResult($"Число {num} в степени {degree} равно {resMath} (Math)"); //вывод результата 1 Math.Pow

// //вывод результата 2
// PrintResult("Число " + num + " в степени " + degree + " равно " + res);

// //программа, короткий вариант
// PrintResult("Ответ: " + NatDegree(ReadData("Ваше число: "), ReadData("В какую степень возвести? ")));



//==========================================================================
////// В общем тут я пыталась сделать калькулятор, но ничего так и не вышло, потом может разберусь :)
// //чтение данных пользователя
// (int numberA, string arOperator, int numberB) ReadData2(string line)
// {
//     //выводим сообщение
//     Console.WriteLine(line);
//     //считываем число
//     int numberA = int.Parse(Console.ReadLine() ?? "0");
//     string arOperator = Console.ReadLine();
//     int numberB = int.Parse(Console.ReadLine() ?? "0");
//     //возвращаем значение
//     return (numberA, arOperator, numberB);
// }

// int Calculator(int numberA, string arOperator, int numberB)
// {
//     int res;
//     if (arOperator == "+") res = numberA + numberB;
//     if (arOperator == "-") res = numberA - numberB;
//     if (arOperator == "*") res = numberA * numberB;
//     if (arOperator == "/") res = numberA / numberB;
//     if (arOperator == "^") res = numberA ^ numberB; //Math.Pow(numberA, numberB);
//     Console.WriteLine(res);
//     return res;
// }

// //вывод результата
// void PrintResult2(string line)
// {
//     Console.WriteLine(line);
// }

// int inputData = ReadData2("Введите то сё: ").numberA;
// string inputData2 = ReadData2("Введите то сё: ").arOperator;
// int inputData3 = ReadData2("Введите то сё: ").numberB;
// PrintResult2(Calculator(inputData, inputData2, inputData3));
