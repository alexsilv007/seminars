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