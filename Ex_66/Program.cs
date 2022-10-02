// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введит первое число.");
string checkResult = Console.ReadLine();
ValidateInput(checkResult);
int m = Convert.ToInt32(checkResult);

Console.WriteLine("Введит второе число.");
checkResult = Console.ReadLine();
ValidateInput(checkResult);
int n = Convert.ToInt32(checkResult);

int result = 0;
int summand = m;
while(summand <= n)
{
    result += summand;
    summand++;
}

Console. WriteLine($"Сумма натуральных чисел от {m} до {n} равна: {result}");

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

