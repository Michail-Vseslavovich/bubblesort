int[] massive = new int[30000];
for (int i = 0; i <massive.Length; i++)
{
    Random r = new Random();
    massive[i] = r.Next(0,30000);
}
for (int i = 0;i < massive.Length;i++)
{
    for (int j = 0; j < massive.Length - i - 1; j++)
    {
        if (massive[j] > massive[j+1])
        {
            int saved = massive[j];
            massive[j] = massive[j+1];
            massive[j + 1] = saved; 

        }
    }
}
foreach (int num in massive)
{
    Console.WriteLine(num);
}