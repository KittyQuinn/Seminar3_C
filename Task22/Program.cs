// принимает число N и выдает квадраты чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25

Console.Clear();
Console.WriteLine("Type the number ");
int num = int.Parse(Console.ReadLine());

int i;

for (i=1; i<=num; i++)
Console.WriteLine(Math.Pow(i,2));