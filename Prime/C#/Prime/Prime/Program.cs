int startNum = 2;
int endNum = 100;

for (int i = startNum; i <= endNum; i++)
{
    bool prime = true;

    for (int j = i - 1; j > 1; j--)
    {
        if (i % j == 0)
        {
            prime = false;
            break;
        }
    }

    if (prime == true)
    {
        Console.WriteLine(i);
    }
}
