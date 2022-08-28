/* //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трёхзначное число ");
int num = int.Parse(Console.ReadLine());

while(num >= 1000)
    {
    Console.WriteLine("Введите трёхзначное число ");
    num = int.Parse(Console.ReadLine());
    }

int num1 = (num%100)/10;
Console.WriteLine(num1);

Console.WriteLine(num + " -> " + num1); */

/* //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int num = new Random().Next(0,1000);
//Console.WriteLine("Введите трёхзначное число ");
//int num = int.Parse(Console.ReadLine());
//while(num >= 1000)
    //{
    //Console.WriteLine("Введите трёхзначное число ");
    //num = int.Parse(Console.ReadLine());
  //  }
 if(num <= 99)
    {
      Console.WriteLine(num + " - Число является двухзначным");
    }
        else
           {
            int a2 = num % 10;
            Console.WriteLine(num + " -> " + a2);
        } */

/*  //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine());

while(num >= 8)
    {
    Console.WriteLine("Введите число от 1 до 7: ");
    num = int.Parse(Console.ReadLine());
    }

if(num<= 5)
{
  Console.WriteLine(num + " Не является выходным днём");
}
else 
{
  Console.WriteLine (num + " Является выходным днём");
} */