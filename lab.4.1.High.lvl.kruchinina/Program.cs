//22var high lvl
Console.Write("Введите размер массива:");
int s = int.Parse(Console.ReadLine());
int[] mas = new int[s];
Random r = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = r.Next(10, 100);
    Console.Write(mas[i] + " ");
}
Console.WriteLine();

for (int i = 1; i < mas.Length - 1; i++)
{
    if (mas[i] > mas[i - 1] && mas[i] < mas[i + 1])
    {
        s = i;
    }
}

if (s != -1)
{
    Console.WriteLine("Номер последнего элемента: " + s);
}
else
{
    Console.WriteLine("Таких элементов нет");
}
