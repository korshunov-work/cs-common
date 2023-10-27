void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

int DigitSum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

int DigitMultiply(int number)
{
    int result = 1;
    while (number > 0)
    {
        result *= number % 10;
        number /= 10;
    }
    return result;
}

int[] GetRandomIntrestingNumberArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        bool check = false;
        while (check == false)
        {
            int element = new Random().Next(minValue, maxValue + 1);
            if (DigitMultiply(element) != 0 && DigitMultiply(element) % DigitSum(element) == 0)
            {
                array[i] = element;
                check = true;
            }
        }

    }
    return array;
}

int[] userArray = GetRandomIntrestingNumberArray(10, 10, 1000);
PrintArray(userArray);