// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool ValidateNum(int number)
{
    if (number < 1 || number > 7)
    {
        System.Console.WriteLine("Вы ввели неверное число!");
        return false;
    }
    return true;  
}
System.Console.WriteLine("Введите число дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if(ValidateNum(number))
{
if (number > 5)
    {
        System.Console.WriteLine("Этот день выходной!");
    }
else
    {
        System.Console.WriteLine("Это рабочий день!");
    }

}