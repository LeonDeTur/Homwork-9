// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введит первое число.");
string checkResult = Console.ReadLine();
ValidateInput(checkResult);
int a = Convert.ToInt32(checkResult);

Console.WriteLine("Введит второе число.");
checkResult = Console.ReadLine();
ValidateInput(checkResult);
int b = Convert.ToInt32(checkResult);

Console.WriteLine(GetAkkermanFunction(a,b));

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

int GetAkkermanFunction (int m, int n)
{
    if (m == 0) {return n+1;}
    if (m > 0 && n == 0) {return GetAkkermanFunction(m-1,1);}
    if (m > 0 && n > 0) {return GetAkkermanFunction(m-1,GetAkkermanFunction(m,n-1));}
    return GetAkkermanFunction(m,n);
}