// Составить программу, которая меняет местами два любых элемента двумерного массива.
int[,] CreateNew2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Print2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Change2dArray(int[,] array, int rowIndex1, int colIndex1, int rowIndex2, int colIndex2){
    int[,] newArr = array;
    int newVar = array[rowIndex1, colIndex1];
    array[rowIndex1, colIndex1] = array[rowIndex2, colIndex2];
    array[rowIndex2, colIndex2] = newVar;
    return newArr;
}

Console.Write("Input rows count: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns count: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateNew2dArray(row, column, minValue, maxValue);
Print2dArray(newArray);

Console.Write("Input a row index for 1st element: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column index for 1st element: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a row index for 2nd element: ");
int r2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column index for 2nd element: ");
int c2 = Convert.ToInt32(Console.ReadLine());
Print2dArray(Change2dArray(newArray, r1, c1, r2, c2));

// Дан двумерный массив. Определить сумму элементов на его i-й строке 
int FindSumOfElemOnRow(int[,] array, int rowNumber){
    int sum = 0;
    for(int i = 0; i < array.GetLength(1); i++){
        sum += array[rowNumber, i];
    }
    return sum;
}
Console.Write("Input rows count: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns count: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minValue: ");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maxValue: ");
int maxV = Convert.ToInt32(Console.ReadLine());

int[,] newArr = CreateNew2dArray(r, c, minV, maxV);
Print2dArray(newArr);

Console.Write("Input a row number: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());

int result = FindSumOfElemOnRow(newArr, rowNumber);
Console.WriteLine($"The sum of elements on {rowNumber} row is {result}");