void Chetnye()
{
    int count = 0;
    Random rnd = new Random();
    int size = rnd.Next(3, 15);
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 1000);
        if (array[i] % 2 == 0)
        {
            count++;
        }
        Console.WriteLine(array[i] + " ");
    }
    Console.WriteLine(count);
}

Chetnye();