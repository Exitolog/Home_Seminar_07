// Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

void Main()
{



    int[] array = { 3, 7, -5, 9, 4, -11, 8 };
    PrintArray(array);



    void PrintArray(int[] array, int i = 0)
    {
        if (i < array.Length)
        {
            PrintArray(array, i + 1);
            Console.Write(array[i] + " ");
            //PrintArray(array, i+1);
        }
    }

}
Main();
