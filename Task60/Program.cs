﻿// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] FillArray3d(int rows, int columns, int depth)
{
    int[,,] arr3d = new int[rows, columns, depth];
   for(int i = 0; i < arr3d.GetLength(0); i++)
   {
       for(int j = 0; j < arr3d.GetLength(1); j++)
       
          {
              for(int k = 0; k < arr3d.GetLength(2); k++)
               {
                 for(int n = 10; n == 99; n++)
                 {
                     arr3d[i, j, k] = n;
                 }
             
               }
          }
   }
   return arr3d;
}
void PrintArray3d(int[,,] arr3d)
{
     for(int i = 0; i < arr3d.GetLength(0); i++)
   {
       for(int j = 0; j < arr3d.GetLength(1); j++)
       
          {
              for(int k = 0; k < arr3d.GetLength(2); k++)
               {
                 for(int n = 10; n == 99; n++)
                 {
                    arr3d[i, j , k] = n;
                     Console.WriteLine($"{arr3d[i, j, k]}({i},{j},{k}) ");                      // 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
                                                                                              // 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
                 }
             
               }
          }
   }
}
int[,,] fillArray3d = FillArray3d(2, 2, 2);
PrintArray3d(fillArray3d);
