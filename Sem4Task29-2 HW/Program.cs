// ==========================================================================
// #29-2  *Дополнительно: Написать программу, которая из имен через 
// запятую выберет случайное имя и выведет в терминал.
// Например: Игорь, Антон, Сергей -> Антон
// Подсказка: Для разбора строки использовать метод string.Split(). 
// Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1). 
// ==========================================================================

//чтение данных пользователя
string ReadData(string line)
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    string names = Console.ReadLine() ?? "0";
    //возвращаем значение
    return names;
}

//выбор имени из списка
string GenName(string listOfNames)
{
    string chosenName;
    string[] arrList = listOfNames.Split(',');
    int nameIndex = new Random().Next(arrList.Length); //длина массива это индекс массива + 1, поэтому здесь всё ок и добавлять +1 не нужно
    chosenName = arrList[nameIndex];
    return chosenName;
}

//вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//вызов методов
PrintResult("Случайно выбранное имя: " + GenName(ReadData("Введите имена через запятую: ")));