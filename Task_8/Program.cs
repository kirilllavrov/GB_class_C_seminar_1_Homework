Console.WriteLine("Введи число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
int even = 0;

while (count < N)
{
    even = even + 1;
    if (even % 2 == 0) Console.Write(even);
    if (even % 2 == 0 && even < N-1) Console.Write(", ");
    count++;
}