 
 Console.Clear();
 Console.Write("Введите 1-ое число: ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите 2-ое число: ");
 int b = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите 3-eе число: ");
 int c = Convert.ToInt32(Console.ReadLine());
 int max = 0;
 if (a > b)
    max = a;
 else if (b > c)
    max = b;
 else
     max = c;
Console.WriteLine($"max = {max}");