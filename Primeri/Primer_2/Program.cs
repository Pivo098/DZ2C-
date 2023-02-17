// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int InputInt(string message)                                
{
    System.Console.Write($"{message}");                 
    int value;                                           
    if (int.TryParse(Console.ReadLine(), out value))      
    {                                                      
        return value;                                    
    }                                                      
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);                                  
    return 0;                                            
}

bool ValidateNum(int num)
{
    if (num < 100)
    {
    System.Console.WriteLine("Третьей цифры не существует");
    return false;
    }
    return true;
}

int In3(int num)
{
    for (int i = 1; num > 999; i++)
    {
        num /= 10;
    }    // у цикла for три параметра: 1 - инициализация, 2 - условие продолжения, 3 - команда в конце каждого цикла
    return num % 10;
}
int num = InputInt("Введите число > ");

if(ValidateNum(num))
{
    System.Console.WriteLine($"Третья цифра числа {num} является {In3(num)}");
}