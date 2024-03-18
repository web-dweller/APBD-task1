// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// Modification 1
// Modification 2
// Modification 3

int[] numbers = { 10, 20, 30, 40, 50 };
double average = CalculateAverage(numbers);
int maxValue = FindMaximum(numbers);
Console.WriteLine("Average: " + average);
Console.WriteLine("Maximum Value: " + maxValue);

static double CalculateAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("Array cannot be null or empty.");
    }

    int sum = 0;
    foreach (int n in numbers)
    {
        sum += n;
    }

    return (double)sum / numbers.Length;
}

static int FindMaximum(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("Array cannot be null or empty.");
    }

    int max = numbers[0];
    foreach (int num in numbers)
    {
        if (num > max)
        {
            max = num;
        }
    }

    return max;
}