        int[] tablica = { 64, 34, 25, 12, 22, 11, 90 };
        Babelkowe(tablica);
        Console.WriteLine("Posortowana tablica: ");  

        foreach (int value in tablica)
        {
        Console.WriteLine(value);
        }
        
    

    static void Babelkowe(int[] arr)
    {
        
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // zamiana arr[j+1] i arr[j]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
