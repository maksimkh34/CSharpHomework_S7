//funcs

void fillarray_s(int[,] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
}

void printarray(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.Write(array[array.Length - 1] + ". ");
}

void printarray_s(int[,] array)
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

double[] findaverage(int[,] array)
{
    double[] answers = new double[array.GetLength(1)];
    double tempanswer = 0;
    int length0 = array.GetLength(0);
    int length1 = array.GetLength(1);
    for (int i = 0; i < length1; i++)
    {
        tempanswer = 0;
        for (int j = 0; j < length0; j++)
        {
            tempanswer += array[j, i];
        }
        answers[i] = Math.Round(tempanswer / length0, 2);
    }
    return answers;
}
//main

int n = getInteger("Enter n: ");
int m = getInteger("Enter m: ");

int[,] array = new int[n, m];

fillarray_s(array, 0, 10);
printarray_s(array);

double[] answers = findaverage(array);
Console.WriteLine();
printarray(answers); 