/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0  */  

int[] testArray = {-6,3,5,38,44}; 

int resultOddNumber = 0; 



for (int i = 0; i < testArray.Length; i++)
{
    if (testArray[i]%2==1 ) resultOddNumber += testArray[i]; 
    
}

Console.WriteLine($"sumOdd: {resultOddNumber}");