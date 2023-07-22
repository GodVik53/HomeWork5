

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Write("Введите количество элементов массива:");
int a = Convert.ToInt32(Console.ReadLine());
double[] num = new double[a];

void mas(int a)
{
Random rand = new Random();
for (int i = 0; i < a; i++)
{
num[i] = rand.Next(0,100) + rand.NextDouble();
Console.Write($"{num[i]:F2}"+" ");
}

}

//double raz(double[] num)
//{
mas(a);

double min = num[0];
double max = num[0];
int i = 1;
while (i < num.Length)
{
if (max<num[i])
max = num[i];
if (min>num[i])
min = num[i];
i++;
}

double raz = max - min;
//return max-min;
//}
Console.WriteLine();
Console.WriteLine($"{max:F2}");
Console.WriteLine($"{min:F2}");
Console.WriteLine(" ");

Console.Write($"Разница между максимальным и минимальным элементами массива:{raz:F2}");
