// Задача 15
// Принять цифру дня недели и проверить, выходной ли этот день



Console.WriteLine("Введите число, соответствующее дню недели.");
int number = Convert.ToInt16(Console.ReadLine());

string strRes = Days(number);                      // присвоение переменной strRes результата выполнения метода Days и вывод strRes
Console.WriteLine(strRes);

string Days(int number)                            // метод Days
{
    string message;
    if(number == 6 | number == 7) {                // если числа 6 или 7, то день выходной
        message = "Этот день выходной.";
    }
    else {
        if(number > 0 && number < 6) {             // если не 6 или 7, то возможно число от 1 до 5, соответствующее рабочему дню
            message = "Этот день рабочий.";
        }
        else {
            message = "Такого дня недели нет. Необходимо число от 1 до 7.";   // если не 6, не 7 и не число от 1 до 5, значит, ошибка ввода
        }
    }
    return message;
}
