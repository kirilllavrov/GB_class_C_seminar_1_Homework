Console.WriteLine("Введи число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
//int even = 0;       // Можно обойтись одной переменной, убираем even

while (count <= N)  // Подправил под одну переменную
{
    even = even + 1;
    if (even % 2 == 0) Console.Write(even + ", ");
    count++;
}
