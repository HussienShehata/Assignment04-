﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //Console.WriteLine("Enter the number : ");
            //int x;
            //int.TryParse(Console.ReadLine(), out x);
            //for(int i=0; i<=x; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q2

            //Console.WriteLine("Enter the number : ");
            //int x;
            //int.TryParse(Console.ReadLine(), out x);
            //int output;
            //for(int i = 1; i<13;i++)
            //{
            //    output = x * i;
            //    Console.WriteLine(output);

            //}

            #endregion

            #region Q3


            //Console.WriteLine("Enter the number :");
            //int x;
            //int.TryParse(Console.ReadLine(), out x);
            //for (int i = 1; i < x; i++)
            //{
            //    if(i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            #endregion

            #region Q4
            // first way 


            //Console.WriteLine("Enter the two number : ");
            //double x, y;
            //double.TryParse(Console.ReadLine(), out x);
            //double.TryParse(Console.ReadLine(), out y);
            //double result = Math.Pow(x,y);
            //Console.WriteLine($"The result is {result}");


            // second way


            //Console.WriteLine("Enter the two number : ");
            //int  z,w ;
            //int.TryParse(Console.ReadLine(), out z);
            //int.TryParse(Console.ReadLine(), out w);

            //int result=1;
            //for(int i=1; i<=w ;i++)
            //{
            //    result = z*result;
            //    Console.WriteLine(result);
            //}

            #endregion


            #region Q5

            //Console.WriteLine("Enter the marks of five subjects");
            //int[] marks = new int[5];
            //int avg, prec;

            //for (int i = 0; i < marks.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out marks[i]);
            //    ;
            //}
            //avg = (marks[0] + marks[1] + marks[2] + marks[3] + marks[4]) / 5;
            //prec = (marks[0] + marks[1] + marks[2] + marks[3] + marks[4]) / 500 * 100;
            //Console.WriteLine($"The avg is {avg }");
            //Console.WriteLine($"The precentage is {avg}%");
            #endregion

            #region Q6




            //Console.WriteLine("Enter string :");
            //string name = Console.ReadLine();
            //for(int i = name.Length-1;i>=0;i--)
            //{
            //    Console.WriteLine(name[i]); 
            //}

            #endregion



            #region Q7


            //int x;
            //int.TryParse(Console.ReadLine(), out x);

            //for (int i = x;i>0 ;i--)
            //{
            //    Console.WriteLine(i);   
            //}

            #endregion



            #region Q8  unanswered

            //Console.WriteLine("Enter the two numbers :");
            //int x, y;
            //int.TryParse(Console.ReadLine(), out x);
            //int.TryParse(Console.ReadLine(), out y);
            //int prime;
            //for (int i = x; i <= y; i++)
            //{
            //    if (i % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            #endregion

            #region Q9 unanswered



            #endregion


            #region  Q10

            //int[] x= new int[2];
            //int[] y= new int[2];
            //int[] z= new int[2];
            //Console.WriteLine("Enter the first point");
            //for (int i =0; i<2;i++)
            //{

            //    int.TryParse(Console.ReadLine(), out x[i]);
            //    Console.WriteLine(x[i]);
            //}


            //Console.WriteLine("Enter the second point");
            //for (int i = 0; i < 2; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out y[i]);
            //    Console.WriteLine(y[i]);
            //}

            //Console.WriteLine("Enter the third point");
            //for (int i = 0; i < 2; i++)
            //{

            //    int.TryParse(Console.ReadLine(), out z[i]);
            //    Console.WriteLine(z[i]);
            //}

            //if (x[0] == y[0] && x[0] == z[0] || x[1] == y[1] && x[1] == z[1])
            //{
            //    Console.WriteLine("The three points are on the same straight line"); 
            //}
            //else
            //{
            //    Console.WriteLine("The three points are not on the same straight line");
            //}
            #endregion


            #region Q11

            //int x;
            //int.TryParse(Console.ReadLine(), out x);
            //for (int i = 1; i < x; i++)
            //{
            //    Console.WriteLine(i);
            //    for (int j = 1; j < x; j++)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}
            #endregion

            #region Q12
            //Console.WriteLine("Enter the elements of the array :");
            //int[] numbers = new int[5];
            //int sum=0;
            //for (int i=0;i<numbers.Length;i++ )
            //{
            //    int.TryParse(Console.ReadLine(), out numbers[i]);

            //}

            //for (int j = 0; j < numbers.Length; j++)
            //{
            //    sum = sum + numbers[j];
            //}
            //Console.WriteLine(sum);
            #endregion


            #region Q13 


            //Console.WriteLine("Enter the elements of the first array :");
            //int[] numbers = new int[2];
            //int[] numbers2 = new int[2];
            //int[] mergeNumbers = new int[4];
            //int x;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out numbers[i]);
            //}

            //Console.WriteLine("Enter the elements of the second array :");
            //for (int j = 0; j < numbers2.Length; j++)
            //{
            //    int.TryParse(Console.ReadLine(), out numbers2[j]);
            //}

            //Console.WriteLine("Merge of two arrays :");
            //for (int k = 0; k < numbers.Length; k++)
            //{
            //    mergeNumbers[k] = numbers[k];
            //    Console.WriteLine(mergeNumbers[k]);
            //}

            //for (int k = 2; k < mergeNumbers.Length; k++)
            //{
            //    mergeNumbers[k] = numbers2[k - 2];
            //    Console.WriteLine(mergeNumbers[k]);
            //}

            //for(int i=0;i<mergeNumbers.Length;i++ ) //{1,10,5,3,6,8}
            //{
            //    for (int j = 0;j<mergeNumbers.Length-1;j++)
            //    {
            //        if (mergeNumbers[j] > mergeNumbers[j+1])
            //        {
            //            x = mergeNumbers[j+1];//1
            //            mergeNumbers[j+1]=mergeNumbers[j];//10
            //            mergeNumbers[j]=x;//1
            //        }
            //    }
            //}
            //Console.WriteLine("sorting of merged array :");
            //for (int i = 0; i < mergeNumbers.Length; i++)
            //{
            //    Console.WriteLine(mergeNumbers[i]);
            //}



            #endregion


            #region Q14 


            //int[] number = { 1,3,3,5,6,6,6,1 };
            //int[] count = new int[8];

            //for (int i = 0; i < number.Length; i++)
            //{
            //    for (int j = 0; j < number.Length ; j++)
            //    {
            //        if (number[j] == number[i])
            //        {
            //            count[i]++;
            //        }
            //    }
            //}
            //for (int i = 0; i < number.Length; i++)
            //    {
            //    Console.WriteLine(count[i]);
            //    }
            #endregion

            #region Q15  
            //int[] number = new int[5] ;

            //int x = 0;
            //Console.WriteLine("Enter the elements of array :");
            //for (int i = 0; i < number.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out number[i]);
            //}

            //for (int i = 0; i < number.Length; i++)
            //{
            //    for (int j = 0; j < number.Length - 1; j++)
            //    {
            //        if (number[j] >= number[i])//3>2
            //        {
            //            x = number[j];//3
            //            number[j] = number[i];//2
            //            number[i] = x;//3

            //        }
            //    }
            //}

            //Console.WriteLine($"Minimum element in this array ={number[0]}");
            //Console.WriteLine($"Maximum element in this array {number[4]}");


            #endregion

            #region Q16
            //Console.WriteLine("enter the elements of the array");
            //int[] number = new int[4];
            //int x;
            //for(int i=0;i<number.Length;i++)
            //{
            //    int.TryParse(Console.ReadLine(), out number[i]);
            //}
            //for(int i=0;i<number.Length;i++)
            //{
            //    for(int j=0;j<number.Length;j++)
            //    {
            //        if (number[j] > number[i])
            //        {
            //            x = number[i];
            //               number[i] = number[j];
            //            number[j] = x;
            //        }
            //    }
            //}
            //Console.WriteLine("array after sorting");
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}
            //Console.WriteLine($"The second highest element in the array {number[2]}");

            #endregion


            #region Q17

            //Console.WriteLine("Enter the elements of the array");
            //int[] number = new int[5];
            //int[] counter =new int[5] ;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out number[i]);
            //}
            //Console.WriteLine("The elements of the array: ");
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            //for(int i = 0;i < number.Length; i++)
            //    for(int j = 0; j < number.Length; j++)
            //    {
            //        if(number[i] == number[j])
            //        {
            //            //for (int k = 0; k < counter.Length; k++)
            //            //{
            //                counter[i] += 1 ;
            //            //}
            //        }
            //    }
            ////Console.WriteLine("lend")
            //for (int i = 0; i<counter.Length; i++)
            //{
            //    Console.WriteLine($"Length between each same elemnts is :{ counter[i]}");
            //}

            #endregion

            #region Q18

            //string statement = Console.ReadLine();
            //string[] listOfWords = statement.Split(' ');
            //Console.WriteLine(listOfWords.Length);
            //for (int i = listOfWords.Length-1; i >= 0; i--)
            //{
            //    Console.Write($"{listOfWords[i]} ");
            //}

            #endregion


            #region Q19

            //int[,] numbers = new int[2, 3];
            //int[,] copyNumbers = new int[2, 3];
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    Console.WriteLine($"the row is {i + 1} :");
            //   for (int j = 0; j < numbers.GetLength(1); j++)
            //   {
            //    int.TryParse(Console.ReadLine(), out numbers[i, j]);
            //   }
            //}
            //Console.WriteLine("multidimensional array is :");
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{

            //    Console.WriteLine($" the row is {i + 1}:");

            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"{numbers[i, j]} ");
            //    }

            //}

            //Array.Copy(numbers, copyNumbers, 6);

           
            //Console.WriteLine("Copy of multidimensional array is :");
            //for (int i = 0; i < copyNumbers.GetLength(0); i++)
            //{

            //    Console.WriteLine($" Second array row is {i + 1}:");

            //    for (int j = 0; j < copyNumbers.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"{copyNumbers[i, j]} ");
            //    }

            }

            #endregion


            #region Q20
            //Console.WriteLine("Enter The one dimensional array:");
            //int[] numbers = new int[5];
            //for(int i=0; i<numbers.Length; i++)    
            //{
            //   int.TryParse( Console.ReadLine(),out numbers[i]);
            //}
            //Console.Write($"Reversed elements ofthis array is : ");
            //for (int i =numbers.Length-1;i>=0 ;i--)
            //{
            //    Console.Write($"{numbers[i]} " );
            //}



            #endregion
        }
    }
    
}
