/* Напишите цикл, который принимает на вход два числа (А и В) 
и возводит число А в натуральную степень В.*/

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int multNumberByNumber(int A, int B)
{
    int mult = 1;
    for (int number = 1; number <= numberB; number++)
    {
        mult *= numberA;
    }
    return mult;
}

int result = multNumberByNumber(numberA, numberB);
Console.WriteLine($"Число {numberA} в натуральной степени числа {numberB} = {result}");