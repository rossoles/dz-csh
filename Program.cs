/*
 //задание 2
 
        int a, b;
 
        Console.WriteLine("Введите два числа : ");
 
        a = Convert.ToInt32(Console.ReadLine());
 
        b = Convert.ToInt32(Console.ReadLine());
 
        if (a > b)
 
        {
 
            Console.WriteLine("{0} наибольшее число", a);
 
        }
 
        else
 
        {
 
            Console.WriteLine("{0} наибольшее число ", b);
 
        }
 
        Console.ReadLine();
 
    
*/


//задание 4.Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {

        Console.WriteLine("Максимальное число: " + firstNumber);
    }

    else
    {
        Console.WriteLine("Максимальное число: " + thirdNumber);
    }
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine("Максимальное число: " + secondNumber);
}
else
{
    Console.WriteLine("Максимальное число: " + thirdNumber);
}
*/
//задание 6.
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*

            Console.WriteLine("Введите число:");
           int  num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 1)
            {
                Console.WriteLine("Число " + num + " нечетное");
            }
            else
            {
                Console.WriteLine("Число " + num + " четное");
            }
            
            */

           //Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
           /*

            int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + num);
            while (i <= num)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }
            
            */