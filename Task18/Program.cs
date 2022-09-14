// По номеру четверти показывает диапазоны x и y

Console.Clear();
Console.WriteLine("Write number of quarter: ");
int num = int.Parse(Console.ReadLine());

if (num == 1)
Console.WriteLine("x > 0 , y > 0");

else if (num == 2)
Console.WriteLine("x < 0 , y > 0");

else if (num == 3)
Console.WriteLine("x < 0 , y < 0");

else if (num == 4)
Console.WriteLine("x > 0 , y < 0");

else 
Console.WriteLine("Write another number");