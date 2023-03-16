void Programm()
{
    double[] array = new double[] {1.0, 24.2442, 49.423, 99.99, 235.51, 0.9, 100.5 };
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    Console.WriteLine(max);
    Console.WriteLine(min);
}

Programm();