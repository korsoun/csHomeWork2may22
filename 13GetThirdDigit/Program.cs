// Задача 13
// вывести третью цифру заданного числа или сообщить, что ее нет

Console.WriteLine("Введите целое неотрицательное число");
int numFromCons = Convert.ToInt32(Console.ReadLine());

GetThirdDigit(numFromCons);                                                     //вызов метода GetThirdDigit c результатом обработки введенного числа  

void GetThirdDigit(int numFromCons)                              // описание метода GetThirdDigit
{
    int denom;                                                   // через denom и frontDigit идет проверка разрядности числа, 
    int frontDigit = 10;
    if (numFromCons / 100 != 0)                                  // проверка на недопустимый ввод. расчет ведется при вводе трех- и более значном числе
    {
        for (denom = 100; frontDigit > 9; denom = denom * 10)    // цикл поиска разрядности. достижение frontDigit значения 9 и менее говорит о том, что frontDigit является последней цифрой при движении справа налево
        {
            frontDigit = numFromCons / denom;
        }    
        numFromCons = (numFromCons / (denom / 1000)) % 10;       // отбросить три ноля у denom. поделить число на denom и взять целую часть, у которой искомая цифра является последней. взять остаток деления целой части на 10               
        Console.WriteLine("Третья цифра числа - " + numFromCons + ".");          
    }                                                                           
        else
    {
        Console.WriteLine("В этом числе нет третьей цифры.");                       //если целой части при делении на 100 нет, значит, число меньше ста и разряда сотых в нем нет
    }
}
