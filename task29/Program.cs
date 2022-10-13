const int Size = 8;
int[] ourArray = new int[Size];
FillArray(ourArray, Size);
PrintArray(ourArray, Size);


void FillArray(int[] arr, int size)
{

    for (int i = 0; i < size; i++)
    {
        int a = new Random().Next(0, 100);
        arr[i] = a;

    }
}

void PrintArray(int[] arr, int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}