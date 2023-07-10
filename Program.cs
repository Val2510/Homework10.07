//Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в 
//промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
int InputNum(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

void PrintNumbers(int start, int end)
{
    if (start > end) return; 
    PrintNumbers(start + 1, end);  
    Console.Write(start + " "); 

}
int num = InputNum("Введите целое число: ");
PrintNumbers(1, num);
*/


//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
int InputNum(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int Sum(int a, int b)
{
    if (a == b) return b;
    return a + Sum(a + 1, b);
}


int num1 = InputNum("Введите целое число M: ");
int num2 = InputNum("Введите целое число N: ");
int sumDig = Sum(num1, num2);
Console.WriteLine($"Сумма чисел в промежутке от M до N: " + sumDig);
*/


//Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int InputNum(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int Ack(int a, int b)
{
    if (a == 0) return b + 1;
    else if (b == 0)
    {
        return Ack(a - 1, 1);
    }
    else return Ack(a - 1, Ack(a, b - 1));
}

int num1 = InputNum("Введите неотрицательное число m: ");
int num2 = InputNum("Введите неотрицательное число n: ");
int function = Ack(num1, num2);
Console.WriteLine($"A(m,n)=" + function);