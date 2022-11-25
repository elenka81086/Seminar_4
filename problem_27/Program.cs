/*Напишите программу, которая принимает на вход 
число и выдает сумму цифр в числе */


int getSumFigureOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int figure = number % 10;
        sum += figure;
        int element = number / 10;
        number = element;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = getSumFigureOfDigits(number);
Console.WriteLine($"Для числа {number}, сумма цифр составляет {result}.");
   
   





