Console.WriteLine("Введи число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
//int even = 0;       // Можно обойтись одной переменной, убираем even

while (count <= N)  // Подправил под одну переменную
{
    //even = even + 1;                                              // убираем лишнюю переменную
    if (count % 2 == 0) Console.Write(count);                       // Заменил even на count
    if (count % 2 == 0 && count < N) Console.Write(", ");           // Заменил even на count
    count++;
}