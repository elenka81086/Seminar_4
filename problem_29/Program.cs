/*Напишите программу, которая задаёт массив из 8 
элементов и выводит их на экран*/


int [,] matr = new int [2, 4];
{
    Console.Write("[");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 30);
            Console.Write($" {matr[i, j]} ");
        }
    } 
    Console.Write("]");
}