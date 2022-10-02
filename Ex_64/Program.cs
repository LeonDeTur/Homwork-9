// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Введит первое число.");
string checkResult = Console.ReadLine();
ValidateInput(checkResult);
int m = Convert.ToInt32(checkResult);

Console.WriteLine("Введит второе число.");
checkResult = Console.ReadLine();
ValidateInput(checkResult);
int n = Convert.ToInt32(checkResult);

Console.WriteLine($"Все натуральные числа от {m} до {n}");
while(m <= n)
{
    Console.Write(" " + m);
    m++;
}

// Методы

void ValidateInput (string input)
{
    bool IsNumber = int.TryParse(input, out int number);
    if (!IsNumber) 
    {
        Console.WriteLine("Error: Пожалуйста, введите целое число .");
        Environment.Exit(0);
    }
}