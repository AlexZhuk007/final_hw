// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

        Console.WriteLine("Введите элементы исходного массива (через запятую):");
        string input = (Console.ReadLine()!);

        string[] originalArray = input.Split(',');

        string[] newArray = new string[originalArray.Length];
        int newIndex = 0;

        foreach (string str in originalArray)
        {
            if (str.Trim().Length <= 3) 
            {
                newArray[newIndex] = str.Trim();
                newIndex++;
            }
        }

        string result = string.Join(",", newArray, 0, newIndex);

        Console.WriteLine("\nЭлементы нового массива:");
        Console.WriteLine(result);
