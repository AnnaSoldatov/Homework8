// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < cols; j++)
//             array[i,j] = new Random().Next(min, max+1);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i =0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     }
// }

// int[,] Sort2dArray(int[,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//             for(int j = 0; j<array.GetLength(1); j++){
//                 for(int k = 0; k <array.GetLength(1)-1; k++){
//                     if (array[i,k] < array[i,k+1]){
//                     int temp = array[i,k+1];
//                     array[i,k+1] = array[i,k];
//                     array[i, k] = temp;
//                     }
//                 }
//             }
//     }   
//     return array;
// }



// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows,cols, min, max);
// Show2dArray(array);
// Console.WriteLine();
// int[,] array2 = Sort2dArray(array);
// Show2dArray(array2);


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < cols; j++)
//             array[i,j] = new Random().Next(min, max+1);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i =0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     }
// }

// void MinSum(int[,] array){
//     int index = 0;
//     int minSum = 0;
//     for(int i = 0; i<array.GetLength(0); i++){
//         int sum = 0;
//         for(int j = 0; j<array.GetLength(1); j++){
//             sum +=array[i,j];
//         }
//     Console.WriteLine($"The sum for the {i} string is {sum}");
//         if(i == 0) minSum = sum;
//         else if(sum<minSum){
//         minSum = sum;
//         index = i;
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Minimum sum is in the {index} line");
// }    

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// if (rows == cols) Console.WriteLine("This is a square matrix");
// else{
// int[,] array = CreateRandom2dArray(rows,cols, min, max);
// Show2dArray(array);
// Console.WriteLine();
// MinSum(array);
// }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// int[,] CreateRandom2dArray(){
//     int n = 4;
//     int[,] array = new int[n,n];
//     int i = 0;
//     int j = 0;

//     for(int number = 1; number<= array.GetLength(0) * array.GetLength(1); number++){
//         array[i,j] = number;
//         if(i <= j+1 && i+j < array.GetLength(1) - 1) j++;
//         else if(i < j && i+j >=array.GetLength(0) - 1) i++;
//         else if(i >= j && i+j > array.GetLength(1) - 1) j--;
//         else i--;
//     }
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i =0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     }
// }

// int[,] array = CreateRandom2dArray();
// Show2dArray(array);