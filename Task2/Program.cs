
 Console.Clear();
 Console.Write("Введите 1-ое число: ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите 2-ое число: ");
 int b = Convert.ToInt32(Console.ReadLine());
 if (a > b){ 
     Console.WriteLine($"max = {a}");
     Console.WriteLine($"min = {b}");
 }
 else if (a < b){
     Console.WriteLine($"max= {b}");
     Console.WriteLine($"min= {a}");
 }
 else
     Console.WriteLine("Числа равны");

