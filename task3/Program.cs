Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10; //Остаток от деления (456 % 10 = 450+6)
    int result = firstDigit + lastDigit;

    Console.WriteLine($"Сумма первой и последней цифры = {result}");
}
else
{
    Console.WriteLine("Некорректный ввод");
}