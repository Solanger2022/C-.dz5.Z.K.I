/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */ 


double[] testArray = {3,7,22,2,78}; 

double maxNumber = testArray[0];

double minNumber = testArray[0]; 

double differenceNumber = 0;

for (int i = 0; i < testArray.Length; i++)
{
    if (testArray[i] > maxNumber) 
    {
    
    maxNumber = testArray[i];  
}

    if (testArray[i] < minNumber) 
   { 
    minNumber = testArray[i]; 
   } 

}

differenceNumber = maxNumber - minNumber;
   
Console.WriteLine($"Разница равна: {differenceNumber}");
   

