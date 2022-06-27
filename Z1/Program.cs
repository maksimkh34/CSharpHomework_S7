//funcs

void fillarray_s(double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.NextDouble();
        }
    }
}

void printarray_s(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int getInteger(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//main

int n = getInteger("Enter n: ");
int m = getInteger("Enter m: ");

double[,] array = new double[n, m];

fillarray_s(array);
printarray_s(array);