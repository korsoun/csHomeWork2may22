// Задача 13
// вывести третью цифру заданного числа или сообщить, что ее нет

Console.WriteLine("Введите целое неотрицательное число");
int numFromCons = Convert.ToInt32(Console.ReadLine());

GetThirdDigit(numFromCons);

void GetThirdDigit(int numFromCons) 
{
    if(numFromCons / 100 != 0) {
        int ThirdDigit = (numFromCons % 1000) / 100;
        Console.WriteLine("Третья цифра числа - " + ThirdDigit + ".");
    }
else {
    Console.WriteLine("В этом числе нет третьей цифры.");
}
}
