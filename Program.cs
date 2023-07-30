/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
вещественными числами.
*/
/*
double[,] Create2dDoubleArray(int rows, int columns)
{
    double[,] array=new double[rows, columns];
    Random random = new Random();
    for(int i=0; i<rows; i++)
        for(int j=0; j<columns; j++)
        {
            array[i,j]=random.NextDouble()*10;
            array[i,j]=Math.Round(array[i,j], 2);
        }
    return array;
}
void Show2dArray(double[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {   
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("input a minimum possible: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum possible: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] MyArray = Create2dDoubleArray(rows, columns);
Show2dArray(MyArray);
*/

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
*/
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i=0; i<rows; i++)
    
        for(int j=0; j<columns;j++)
        
            array[i,j] = new Random().Next(minValue, maxValue+1);
        
    return array;
}
void Show2dArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
}

void CheckElement(int i, int j, int[,] array)
{
    bool result = true;
    if (i>array.GetLength(0) || j>array.GetLength(1)) result=false;
    else result=true;
    if (result==true) Console.WriteLine(" Your number is "+array[i,j]);
    else Console.WriteLine("element doesn't exist");
}



Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(myArray);

Console.WriteLine();

Console.Write("Please, input number of row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input number of column: ");
int column = Convert.ToInt32(Console.ReadLine());

CheckElement(row, column, myArray);
*/

/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
*/

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i=0; i<rows; i++)
    
        for(int j=0; j<columns;j++)
        
            array[i,j] = new Random().Next(minValue, maxValue+1);
        
    return array;
}
void Show2dArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
}

double[] Average(int[,] array)
{
    double[] averarray = new double[array.GetLength(1)];
    
    for(int j = 0; j<array.GetLength(1); j++)
    {   double result1  = 0;
        for(int i = 0; i<array.GetLength(0); i++)
        {
            result1=result1+array[i,j];
        }
        double avercol=result1/(double)array.GetLength(0);
        averarray[j] = avercol;
        Console.WriteLine("Column sum " + (j+1)+" = " +result1);
        Console.WriteLine("Average element is "+(j+1)+" = " +avercol);
    }
    return averarray;
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a minimum possible: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximum possible: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] MyArray = CreateRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(MyArray);
Average(MyArray);




