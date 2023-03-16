void Summa()
{
    int sum = 0;
    Random rnd = new Random();
    int size = rnd.Next(3, 15);
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(1, 100);
        if(i % 2 == 1)
        {
            sum += array[i];
        }
        Console.WriteLine(array[i] + " ");
    }
    Console.WriteLine(sum);
}
Summa();