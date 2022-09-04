/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
в промежутке от M до N.*/

void NewTask()
{
    Console.WriteLine("Для перехода к следующей задаче нажмите на любую клавишу...");
    Console.ReadKey();
    Console.Clear();
}

void task_64(int m, int n)
{
    for (int i = m; i <= n; i++)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
task_64(m, n);
NewTask();

/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.*/
void task_66(int m, int n)
{
    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        sum += i;
    }
    Console.WriteLine($"sum = {sum}");
}

Console.Write("m = ");
m = int.Parse(Console.ReadLine());
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
task_66(m, n);
NewTask();

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/

int task_68(int m, int n)
{
    if (m == 0) return n+1;
    else if (n == 0) return task_68(m-1, 1);
    else return task_68(m-1, task_68(m, n-1));
}

Console.Write("m = ");
m = int.Parse(Console.ReadLine());
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
int A = task_68(m, n);
Console.WriteLine($"A({m},{n}) = {A}");




