/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue+1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateSortedMassive(int[,] array)
{ 
    for (int m = array.GetLength(1)-1; m > 0; m--)
    {   
        for (int j = 0; j < m; j++)
        {   for (int i = 0; i < array.GetLength(0); i++)
                    if (array[i,j] > array[i,j+1])
                    {
                        int temp = array[i,j];
                        array[i,j] = array[i,j+1];
                        array[i,j+1] = temp;
                    }
        }
    }
    return array;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.WriteLine("New massive with sorted rows is: ");
Show2dArray(CreateSortedMassive(myArray));
*/


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
находить строку с наименьшей суммой элементов.*/
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int rows = columns+2;
    int[,] newArray = new int[rows, columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue+1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindMinRow(int[,] array)
{
    int index = 0;
    int sum = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            sum += array[i,j];
            if (i == 0) minSum = sum;
            else if (sum < minSum)
            { minSum = sum;
              index = i+1;
            }
        }
        
    }
    
   Console.WriteLine($"Row with the smallest sum is {index}");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

FindMinRow(myArray);
*/


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArrayFirst()
{
    Console.Write("Input numbers of rows for first massive: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns for first massive: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value for first massive: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value for first massive: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue+1);

    return newArray;
}

int[,] CreateRandom2dArraySecond()
{
    Console.Write("Input numbers of rows for second massive: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns for second massive: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value for second massive: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value for second massive: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue+1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ProdactMatrix(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    Console.WriteLine("Can not create new matrix, becouse number of columns of the first matrix is not equel to the number of rows of the second matrix ");

    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i,j] = 0;
            for (int n = 0; n < matrixA.GetLength(1); n++)
            {
                matrixC[i,j] += matrixA[i,n] * matrixB[n,j];
            }
        }
    }
    return matrixC;
}

int[,] myArrayOne = CreateRandom2dArrayFirst();
int[,] myArrayTwo = CreateRandom2dArraySecond();

Show2dArray(myArrayOne);
Show2dArray(myArrayTwo);

int[,] newArray = ProdactMatrix(myArrayOne, myArrayTwo);
Show2dArray(newArray);
*/


/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.*/
/*
void CreateNewArray(int[,,]myArray)
{
    int[] temp = new int[myArray.GetLength(0) * myArray.GetLength(1) * myArray.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 99);
        number = temp[i];
        if (i >= 1)
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 99);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
        }

    }
    int count = 0;
    for (int x = 0; x < myArray.GetLength(0); x++)
    {
        for (int y = 0; y < myArray.GetLength(1); y++)
        {
            for (int z = 0; z < myArray.GetLength(2); z++)
            {
                myArray[x,y,z] = temp[count];
                count ++;
            }
        }
    }

}
void Show3dArray(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
            {
                for (int z = 0; z < array.GetLength(2); z++)
                Console.Write($"{array[x, y, z]} {(x, y, z)}  ");
            Console.WriteLine();
            }
        
    }
    Console.WriteLine();
}

Console.Write("Input numbers of X: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of Y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of Z: ");
    int z = Convert.ToInt32(Console.ReadLine());

int[,,] newArray = new int[x, y, z];

CreateNewArray(newArray);

Show3dArray(newArray);
*/


// Задача 62. Напишите программу, которая заполнит спирально массив
/*

int[,] CreateSpiralArray(int n)
{
    int[,] array = new int[n,n];
    int i =0;
    int k = 0;
    int p = 1;
    while (i<n*n)
    {
        k ++;
        for (int j = 0; j < n-k+1; j++)
    {
        array[(k-1), j] = p++;
        i++;
    }
        for (int j = k; j < n-k+1; j++)
        {
            array[j, (n-k)] = p++;
            i++;
        }
        for (int j = n-k-1; j >= k-1; j--)
        {
            array[(n-k), j] = p++;
            i++;
        }
        for (int j = n-k-1; j >k; j--)
        {
            array[j, (k-1)] = p++;
            i++;
        }
    }
   return array; 
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]:D2} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


 Console.Write("Input numbers of row and columns: ");
 int n = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateSpiralArray(n);

Show2dArray(newArray);
*/