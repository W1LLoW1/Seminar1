// string num1str = Console.ReadLine();
// int num = Convert.ToInt32(num1str);

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
{
    Console.WriteLine("Первое число = квадрат второго числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}



