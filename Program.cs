int Size(string msg)
{
    Console.Write(msg);
    int i = Convert.ToInt32(Console.ReadLine());
    return i;
}

int[] Array(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    return arr;
}

int[] Sort(int[] arr2)
{

    int[] ar = arr2;
    for (int j = 0; j < ar.Length; j++)
    {
        for (int i = 0; i < ar.Length-1; i++)
        {
            int min = ar[i];
            if (ar[i] > ar[i + 1])
            {
                ar[i] = ar[i + 1];
                ar[i + 1] = min;
            }
        }
    }
    for (int u = 0; u<ar.Length; u++)
    {
        Console.Write ($"{ar[u]} ");
    }
    Console.WriteLine();
    return ar;
}

void Collection(int[] col, int Min)
{
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] > Min-1)
        {
            int j = col[i];
            int summ = 0;
            int number = 0;
            for (int k = 0; k < col.Length; k++)
            {
                if (j == col[k])
                {
                    number = col[k];
                    summ = summ + 1;
                    col[k] = Min-1;
                }
            }
            Console.WriteLine($"{number} = {summ} р");
        }

    }
}

int size = Size("Введите количество элементов ");
int min = Size ("Минимальное значение ");
int max = Size ("Максимальное значение ");
int[] arr = Array(size, min, max);
int [] arr2 = Sort(arr);
Console.WriteLine();
Collection(arr2, min);