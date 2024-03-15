using System.Collections;

int[] numbers = { 25, 1, 52, 85, 93, 44, 17, 36, 12, 94, 4, 27, 89, 99, 49, 22, 12, 36, 58, 43, 29, 91, 4 };

ArrayList oddNumbers = new ArrayList();

foreach (int number in numbers)
{
    if (number % 2 != 0)
    {
        oddNumbers.Add(number);
    }
}

foreach (int oddNumber in oddNumbers)
{
    Console.WriteLine(oddNumber);
}
