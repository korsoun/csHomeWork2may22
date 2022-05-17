// Задача 10
// Получить трехзначное число и вывести вторую цифру

//получение числа и перевод в int для переменной
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

//присваивание переменной secondDigit результата выполнения метода
int secondDigit = GetSecondDigit(number);
Console.Write("Вторая цифра этого числа - " + secondDigit);


//метод для нахождения второй цифры
int GetSecondDigit(int number) {
    int result = (number % 100) / 10;
    return result;
}
