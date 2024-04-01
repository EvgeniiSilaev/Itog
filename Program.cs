
//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

/*

void PrintNumFromSEgment(int start, int finish, int count)
{
    if (start == finish + count) return;
    System.Console.Write($"{start} ");
    PrintNumFromSEgment(start + count, finish, count);
}


System.Console.WriteLine("введите натуральное число N");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите натуральное число M");
int m = Convert.ToInt32(Console.ReadLine());

if (n < 1 || m < 1)
{
    System.Console.WriteLine("некорректный ввод данных");
    return;
}

if (n < m) PrintNumFromSEgment(n, m, 1);
else PrintNumFromSEgment(n, m, -1);

*/


/*
//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return Akkerman(n - 1, 1);
    return Akkerman(n - 1, Akkerman(n, m - 1));
}

System.Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

int resultAkk = Akkerman(n, m);
System.Console.WriteLine(resultAkk);
*/


/*
//Задача 3: задайте произвольный массив. Выведите его елементы, начиная с конца. 
// Использовать рекурсию, не использавать циклы 

void PrintElementArr(int[] arr, int size)
{
    if (size == 0) return;
    Console.Write($"{arr[size - 1]} ");
    PrintElementArr(arr, size - 1);

}

int[] array = { 1, 2, 5, 0, 10, 34 };
PrintElementArr(array, array.Length);

*/
