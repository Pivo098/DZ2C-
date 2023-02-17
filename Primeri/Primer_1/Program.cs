// Задача 10: Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int InputInt(string message)                                //название метода
{
    System.Console.Write($"{message}> ");                 //вывод приглашения ко вводу
    int value;                                            // инициализация переменной
    if (int.TryParse(Console.ReadLine(), out value))      //проверка условия корректности ввода + ввод со строки
    {                                                      //если конвертация строки прошла правильно, то мы попадаем в ветку, 
        return value;   //f                                   //которая находится в скобках после наименования функции. Если да
    }                                                       //то выдает первое значение (ввод со строки). Нет - второе (out )
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);                                  //если TryParse не сработало, выходим из программы (Exit) с кодом 1
    return 0;                                             //нужна для компиляции.
}

bool ValidateNum(int num)
{
    if (num < 100 || num >= 1000)
    {
        System.Console.WriteLine("Вы задали не трехзначное число");
        return false;
    }
    return true;  
}
int numd = 0;
int num = InputInt ("Введите трехзначное число: ");    
if (ValidateNum(num))                                                        
{
    numd = num / 10 % 10;  // я только это подсмотрел, всё остальное из семинара                                           
    System.Console.WriteLine($"Вторая цифра числа {numd}"); 
}