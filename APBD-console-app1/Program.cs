// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// Modification 1
// Modification 2
// Modification 3

int[] numbers = { 10, 20, 30, 40, 50 };
double average = CalculateAverage(numbers);
Console.WriteLine("Average: " + average);

static double CalculateAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("Array cannot be null or empty.");
    }

    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }

    return (double)sum / numbers.Length;
}