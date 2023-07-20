//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2



int[] nums = new int[10];
int sum = 0;
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(100, 999);
    Console.Write(nums[i] + " ");
    if (nums[i] % 2 == 0) 
    { sum=sum+1; 
    }

}
Console.WriteLine();
Console.WriteLine("колличество четных чисел - " + sum);

