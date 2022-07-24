//Задача 1
/*int num1, num2;

Console.WriteLine("Input a num1: ");
num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a num2: ");
num2=Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
    Console.WriteLine("max= " +num1);
    Console.WriteLine("min= " +num2);
}
else
if (num1<num2)
{
    Console.WriteLine("max= " +num2);
    Console.WriteLine("min= " +num1);  
}
else
if (num1==num2)
{
    Console.Write("Числа равны");
}*/


//Задача 2
/*int num1, num2, num3;
Console.WriteLine("Input a num1: ");
num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a num2: ");
num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a num3: ");
num3=Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
    Console.WriteLine("max=" +num1);
}
else
if (num2>num3)
{
    Console.WriteLine("max=" +num2);
}
else
if (num3>num1)
{
   Console.WriteLine("max=" +num3); 
}*/


//Задача 3
/*int num;

Console.WriteLine("Input a num: ");
num=Convert.ToInt32(Console.ReadLine());

if ((num%2) ==0)
{
    Console.WriteLine("Чётное");
}
else
{
   Console.WriteLine("Нечётное"); 
}*/


//Задача 4
/*int n;
int x;

Console.WriteLine("Input a n: ");
n=Convert.ToInt32(Console.ReadLine());
x=1;

if(n<=1)
{
    Console.WriteLine("Impossible, minimum 1");
}

while (x<=n)
{
if (x%2==0)
    Console.WriteLine(x + "");
    x++;
}*/






//Задача1 Семинар2.принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
/*int CutNumber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is:" +num);
    int des = num;
    int result = (des%100)/10;
    return result;
}

int number=CutNumber();
Console.WriteLine("Result number is " + number);*/


//Задача 2. Семинар 2.Выводит третью цифру заданного числа или сообщает, что третьей цифры нет
/*int AnyNum(int num)
{
        if (num < 100) num=-1;
    else 
    {
        while(num>=1000)
        num=num/10;
        num=num%10;
        
    }
    return num;
}
Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AnyNum(number));*/

//Задача 3. Семинар 2. принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*void Nedelya(int num)
{
    if (num>=1 && num<6)
    {
        Console.WriteLine("Weekday");
    }
    else
    if (num>5 && num<8)
    {
        Console.WriteLine("Weekend");
    }
}
int number;

Console.WriteLine("Введите день недели: ");
number = Convert.ToInt32(Console.ReadLine());
Nedelya(number);*/






//Задача 1. Семинар 3.Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*void Palin(int num)
{
    if (num/10000 == num%10 && num/1000%10 == (num%100)/10)
    {
        Console.WriteLine("It is palindrom");
    }
    else
    Console.WriteLine("It is not palindrom");
}

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
Palin(number);*/

//Задача 2. Семинар 3. Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
/*void Qube(int N)
{
    int current = 1;
    while (current<=N)
    {
        int Qube = current*current*current;
        Console.WriteLine(Qube);
        current++;
    }
}
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Qube(n);*/



//Задача 1; Семинар 4.Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*int SumN(int num)
{
  int sum=0;
  if (num<0)
  {
    Console.WriteLine("-1");
  }
  else
  {
  while (num>0)
      {
        sum = sum+num%10;
        num=num/10;
      }
}
  return sum;
}

Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumN(number));*/


//Задача 2. Семинар 4.Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*int[] CreateArray(int size)
{
      int[] newArray = new int[size];
      Console.WriteLine("Creatung array here: ");
      for(int i=0; i<size; i++)
  {
          Console.Write($"Input {i+1} element: ");
          newArray[i] = Convert.ToInt32(Console.ReadLine());
  }
      Console.WriteLine();
      return newArray;
}

void ShowArray(int[] array)
{
      for (int i = 0; i < array.Length; i++)
          Console.Write(array[i] + " ");
      Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int []array = CreateArray(size);
ShowArray(array);*/







//Зад 1.Сем 5.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*int[] CreateRandomArray(int size)
{
  int[] newArray = new int [size];
  for (int i =0; i<size; i++)
      newArray[i] = new Random().Next(100, 1000);
  return newArray;
}
int Deistvie(int[] array)
{  
    int count = 0;
    for (int i=0; i<array.Length; i++)
  
    if (array[i]%2 ==0)
    count ++;
    
    return count;
}

void ShowArray(int[] array)
{
  for(int i =0; i<array.Length; i++)
      Console.Write(array[i] + " ");
  Console.WriteLine();
}

Console.Write("Input size of massive: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size);
ShowArray(array);
int kolichestvo = Deistvie(array);
Console.WriteLine("Kolichestvo chetnih chisel: " + kolichestvo);*/


//Зад 2. Сем 5.Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*int[] CreateRandomArray(int size, int minValue,int maxValue)
{
  int[] newArray = new int [size];
  for (int i = 0; i < size; i++)
      newArray[i] = new Random().Next(minValue, maxValue+1);
  return newArray;
}

int Summa(int [] array)
{
  int sum = 0;
  
  for (int i = 0; i < array.Length; i++)
  if (array[i]%2 != 0) sum += array[i]; 
  
  return sum;
}

void ShowArray(int[]array)
{
  for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("Input a size of array:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min number");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max number");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray (size, min, max);
ShowArray(array);
Summa(array);
Console.WriteLine("Summa nechetnih chisel: " + Summa(array));*/



//Зад 3. Сем 5.Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*double [] CreateArray(int size)
{
  double[] newArray= new double [size];
  for (int i=0; i<size; i++)
  newArray[i] = new Random().Next(1, 100);
  return newArray;
}

double Raznost(double[] array)
{
    double min = array[0];
    double max = array[0];
  
        for (int i = 1; i<array.Length; i++)
            if (array[i] < min) min = array[i];
        
        for (int i = 1; i<array.Length; i++)     
            if (array[i] > max) max = array[i];
        
        double dif = max - min;
       
    return dif;
}

void ShowArray(double[]array)
{
  for (int i=0; i<array.Length; i++)
    Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.WriteLine("Input a size of array:");
int size = Convert.ToInt32(Console.ReadLine());
Double[] array = CreateArray(size);
ShowArray(array);
double dif = Raznost(array);
Console.WriteLine("Разница максимума и минимума: " + dif);*/






//Зад1.Сем6.Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*int [] CreateArray(int size)
{
    int[] newArray = new int [size];
    Console.WriteLine("Creating massive here: ");
    for (int i = 0; i < size; i++)
        {
            Console.Write($"Input {i+1} element: ");
            newArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        return newArray;
} 

int Deistvie (int[] Numbers)

{
    int count = 0;
    for(int i = 0; i < Numbers.Length; i++)
    {
        if (Numbers[i] > 0) count +=1;
    }
    return count;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length;i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("Input size of array");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(size);
ShowArray(array);
int kolishestvo = Deistvie(array);
Console.WriteLine("Введено чисел больше 0: " + kolishestvo);*/

//Зад2.Сем6. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
/*int Tochka(int b1, int b2, int k1, int k2)
{
    int x = (b2-b1)/(k2-k1);
    return x;
}

Console.WriteLine("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
int x = Tochka(b1,b2,k1,k2);
int y = k1 * x + b1;
Console.WriteLine();
Console.WriteLine($"Координаты точки пересечения: ({x},{y})");*/





//Зад1.Сем.7.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*double[,] Create2dArray(int columns, int rows)
{
  double[,] newArray = new double [columns, rows];

        for(int i = 0; i < rows; i++)
            for (int j = 1; j < columns; j++)
              newArray[i, j] = new Random().NextDouble()*10;
  return newArray;
}

void Show2dArray(double[,] array)
{
  for(int i = 0; i< array.GetLength(0); i++)
  {
      for (int j = 0; j < array.GetLength(1); j++)
      Console.Write( array[i, j] + " ");
      Console.WriteLine();
  }
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = Create2dArray(m, n);
Show2dArray(array);*/

//Зад 2. Сем.7. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*int Masiv()
        {
            Console.Write("Введите количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Введите количество столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Введите номер строки:");
            int p1 = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Введите номер столбца:");
            int p2 = Convert.ToInt32(Console.ReadLine()) - 1;
            Random random = new Random();
            int[,] array = new int[n, m];
            Console.WriteLine("Готовый массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10, 99);
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            if (p1 < 0 | p1 > array.GetLength(0) - 1 | p2 < 0 | p2 > array.GetLength(1) - 1)
            {
                Console.WriteLine("Такого числа в массиве нет");
            }
            else
            {
                Console.WriteLine("Значение элемента массива = {0}", array[p1, p2]);
            }
         return array[p1, p2];
         }
Masiv();*/


//Зад 3. Сем 7.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
  int[,] newArray = new int [rows, columns];

  for(int i = 0; i < rows; i++)
      for(int j = 0; j < columns; j++)
          newArray[i,j] = new Random().Next(minValue, maxValue+1);
  return newArray;
}

void Srednee(int[,] array)
{
  double[] Sum = new double[array.GetLength(1)];
  for( int j = 0; j < array.GetLength(1); j++)
      {
        for(int i = 0; i < array.GetLength(0); i++)
          {
            Sum[j] = Sum[j] + array[i,j];
          }
          Sum[j] = Sum[j] / array.GetLength(1);
          Console.WriteLine($"Среднеарифметическое столбца {j+1} = {Sum[j]}");
      }
}
void Show2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
{
      for (int j = 0; j < array.GetLength(1); j++)
          Console.Write(array[i,j] + " ");
      Console.WriteLine();
}
}
Console.Write("Input number of  rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of  columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min posiible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Srednee(myArray);*/




//Зад1 Сем9.Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.

/*int SumNums(int n)
{
  int current = 1;
    int i = 1;
    while ( n/i>=10)
    {
        i = i*10;
        current++;
    }
    return current;
}
  
Console.WriteLine("Input n : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество цифр: " + SumNums(n));*/


//Задача2.Семинар9. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*int Sum(int m, int n)
{
  if(n>m)
  {
    return n + Sum(m, n-1);
  }
  else 
  return n;
}
Console.WriteLine("Input n : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(n,m));*/