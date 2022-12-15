Console.WriteLine("Введите несколько чисел, разделенных пробелом: ");
string text = Console.ReadLine();
int[] numbers = Array.ConvertAll(text.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int CountPositiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    return result;
}

Console.WriteLine(CountPositiveNumbers(numbers));