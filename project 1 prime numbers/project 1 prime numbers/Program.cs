int T = 0;
Console.WriteLine("ENTER THE FRIST NUMBER ");
int N1 = int.Parse(Console.ReadLine());

Console.WriteLine("ENTER THE SECOND NUMBER ");
int N2 = int.Parse(Console.ReadLine());


for (int i = N1; i <= N2; i++)
{
    for (int c = 1; c <= i; c++)
    {
        if (i % c == 0)
        {
            T++;
        }
    }

    if (T == 2)
    {
        double perfect1 = Math.Pow(2, i) - 1;
        double perfect2 = Math.Pow(2, i - 1);
        Console.WriteLine("the perfect numbers is  " + perfect1*perfect2);
        T = 0;

    }
    else
    {
        T = 0;
    }

}
