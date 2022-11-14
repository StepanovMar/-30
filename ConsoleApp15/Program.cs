Console.Write($"Введите число от 1 до 6:");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int i = 0;
for (i = 1; i < num; i++)
{
    if (num % i == 0)
        sum += i;
}
if (sum == num)
    Console.WriteLine($"число { num} — совершенное");
else
    Console.WriteLine($"число { num} — НЕ совершенное");