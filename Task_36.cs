
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0




int[] nums = new int[10];
int sum = 0;
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(-100, 100);
    Console.Write(nums[i] + " ");
    if (i % 2 == 1) 
    { sum = sum + nums [i]; 
    }

}
Console.WriteLine();
Console.WriteLine("сумма элементов на нечетных позициях - " + sum);

