// Задача 10
// Получить трехзначное число и вывести вторую цифру

Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine());

int secondDigit = GetSecondDigit(number);
Console.Write("Вторая цифра этого числа - " + secondDigit);

int GetSecondDigit(int number) {
    int result = (number % 100) / 10;
    return result;
}
