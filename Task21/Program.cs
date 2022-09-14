// принимает координат двух точек и находит расстояние между ними в 2Д пространстве

Console.Clear();
Console.WriteLine("Type A(x,y)");
Console.WriteLine("x= ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("y= ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Type B(x,y)");
Console.WriteLine("x= ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("y= ");
int y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));

Console.WriteLine($"The distance between A and B = {result}");