
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), i = 0;
n = Math.Abs(n);
while (i <= n){
if (i%2! == 0)
    Console.Write($"{i} ");
    i = i + 2;
}
