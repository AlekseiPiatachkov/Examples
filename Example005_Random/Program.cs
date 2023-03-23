int numberA = new Random().Next(1, 10); // 1, 2, 3. 4 ....9
Console.Write(numberA);
Console.Write("+");
int numberB = new Random().Next(1, 10); // 1, 2, 3. 4 ....9
Console.Write(numberB);
Console.Write("=");
int result = numberA + numberB;
Console.WriteLine(result);