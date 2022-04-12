Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100)
{
    if (number < 1000)
    {
        int result = number % 10;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Введенное число не является трехзначным");
    }
}
else 
{
    Console.WriteLine("Введенное число не является трехзначным");
}