// упорядочить массив от максимального к минимальному

Console.Clear();
int[] arr = {13, 5, 4, 3, 2, 6, 7, 21, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
        {
            int maxPosition = i;
            for (int j = i+1; j < array.Length; j++)
                {
                    if(array[j] > array[maxPosition]) maxPosition = j;
                        
                }
                int temporary = array[i];
                array[i] = array[maxPosition];
                array[maxPosition] = temporary;
        }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
