// PrintLine();
// Console.WriteLine("Отчёт");
// PrintLine();

//Задание 1
// PrintHeader("заголовок1");
// PrintHeader("заголовок2");

//Задание 2.1
// Console.WriteLine(Max(6, 99));
// Console.WriteLine(Max(76, 3));

//Задание 2.2
// Console.WriteLine(IsEven(4));
// Console.WriteLine(IsEven(7));
// Console.WriteLine(IsEven(0));

//Задание 3
// int[] arr = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine(Average(arr));
// Console.WriteLine(CountGreater(arr, 100));

//Задание 4
// Console.WriteLine($"{0} C = {ToFahrenheit(0)} F");
// Console.WriteLine($"{100} C = {ToFahrenheit(100)} F");
// Console.WriteLine($"{37} C = {ToFahrenheit(37)} F");

//Задание 5
// Console.WriteLine(Factorial(5));
// for (int i = 2; i<=50; i++)
// {
//     if (IsPrime(i) == true)
//     {
//         Console.WriteLine(i);
//     }
// }

//Задание 6
// Console.WriteLine(ReadPositive("Введите число: "));

// static void PrintLine()
// {
//     Console.WriteLine("^_^");
// }

//Итоговая задача. «Меню-калькулятор»
// int n;
// do
// {
//     Console.WriteLine("\n1 – сумма двух чисел");
//     Console.WriteLine("2 – большее из двух чисел");
//     Console.WriteLine("3 – факториал");
//     Console.WriteLine("0 – выход");
//     Console.Write("Выберите пункт меню: ");
//     n = int.Parse(Console.ReadLine());
//     switch (n)
//     {
//         case 1:
//             int num1 = ReadPositive("Введите первое число: ");
//             int num2 = ReadPositive("Введите второе число: ");
//             Console.WriteLine($"Сумма: {num1 + num2}");
//             break;

//         case 2:
//             int max1 = ReadPositive("Введите первое число: ");
//             int max2 = ReadPositive("Введите второе число: ");
//             Console.WriteLine($"большее из двух: {Max(max1, max2)}");
//             break;

//         case 3:
//             int factNum = ReadPositive("Введите число: ");
//             Console.WriteLine($"Факториал: {Factorial(factNum)}");
//             break;

//         case 0:
//             Console.WriteLine("\nДо свидания!");
//             break;

//         default:
//             Console.WriteLine("\nНет такого пункта.");
//             break;
//     }
// } while (n != 0);

//Дополнительное задание ★★★
Console.WriteLine(Gcd(48, 18));
Console.WriteLine(Lcm(4, 6));

//Задание 1
// static void PrintHeader(string title)
// {
//     PrintLine();
//     Console.WriteLine(title);
//     PrintLine();
// }

//Задание 2.1
static int Max(int a, int b)
{
    if (a > b) {
        return a;
    } else {
        return b;
    }
}

//Задание 2.2
static bool IsEven(int n)
{
    if (n % 2 == 0) {
        return true;
    } else {
        return false;
    }
}

//Задание 3
static double Average(int[] arr)
{
    double sum = 0;
    foreach (int i in arr) {
        sum += i;
    }
    return sum/arr.Length;
}
static int CountGreater(int[] arr, int limit)
{
    int count = 0;
    foreach (int i in arr)
    {
        if (i > limit) {
            count++;
        }
    }
    return count;
}

//Задание 4
static double ToFahrenheit(double celsius)
{
    return celsius * 9 / 5 + 32;
}

//Задание 5
static long Factorial(int n)
{
    int f = 1;
    for (int i = 1; i <= n; i++)
    {
        f *= i;
    }
    return f;
}
static bool IsPrime(int n)
{
    bool flag = true;
    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0)
        {
            flag = false;
        }
    }
    return flag;
}

//Задание 6
static int ReadPositive(string message)
{
    int n;
    do
    {
        Console.Write(message);
        n = int.Parse(Console.ReadLine());

    } while (n <= 0);

    return n;
}

//Дополнительное задание ★★★
static int Gcd(int a, int b)
{
while (b != 0) {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}
static int Lcm(int a, int b)
{
   return a / Gcd(a, b) * b; 
}