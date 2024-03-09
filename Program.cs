int[] massive = new int[100000];
Random r = new Random();
for (int i = 0; i <massive.Length; i++)
{
    
    massive[i] = r.Next(0,100000);
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