int[] numbers = { 25, 1, 52, 85, 93, 44, 17, 36, 12, 94, 4, 27, 89, 99, 49, 22, 58, 43, 29, 91 };

foreach (int number in numbers)
{
    bool divisibleBySelf = true;

    foreach (char ch in number.ToString())
    {
        if (number % Convert.ToInt32(ch.ToString()) != 0)
        {
            divisibleBySelf = false;
        }
    }

    if (divisibleBySelf == true)
    {
        Console.WriteLine(number);
    }
}
