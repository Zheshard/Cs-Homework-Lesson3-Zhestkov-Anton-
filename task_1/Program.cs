// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
string nums = Console.ReadLine();

if (nums.Length == 5)
{
	int num = Convert.ToInt32(nums);
	if (nums[0] == nums[4] && nums[1] == nums[3])
	{
		System.Console.WriteLine("Введенное число является палиндромом");
	}
	else
	{
		System.Console.WriteLine("Введенное число не является палиндромом");
	}
}
else
{
	System.Console.WriteLine("Введено неверное значение!");
}

/*
int num = Convert.ToInt32(nums);
System.Console.WriteLine(num);
*/