using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            string vault;
            Console.WriteLine("Введите от 1 до 9, чтобы выбрать задание");
            vault = Console.ReadLine();
            switch (vault)
            {
                case ("1"):
                    int nubmer;
                    Console.WriteLine("Task 1:");
                    Console.WriteLine("Введите число");
                    nubmer = Convert.ToInt32(Console.ReadLine());
                    if (nubmer > 0)
                    {
                        nubmer += 5;
                        Console.WriteLine(nubmer);
                        Console.ReadKey();
                    }
                    else
                    {
                        nubmer -= 5;
                        Console.WriteLine(nubmer);
                        Console.ReadKey();
                    }
                    break;
                case ("2"):
                    int num1, num2, num3;
                    Console.WriteLine("Task 2:");
                    Console.WriteLine("Введите три разных числа");
                    Console.Clear();
                    num1 = Convert.ToInt32(Console.ReadLine());
                    num2 = Convert.ToInt32(Console.ReadLine());
                    num3 = Convert.ToInt32(Console.ReadLine());

                    if (num1 > num2 && num1 > num3)
                    {
                        Console.WriteLine($"Наибольшее число: {num1}");
                        Console.ReadKey();
                    }
                    else if (num2 > num1 && num2 > num3)
                    {
                        Console.WriteLine($"Наибольшее число: {num2}");
                        Console.ReadKey();
                    }
                    else if (num3 > num1 && num3 > num2)
                    {
                        Console.WriteLine($"Наибольшее число: {num3}");
                        Console.ReadKey();
                    }
                    break;
                case ("3"):
                    int n1, n2, n3, sum;
                    Console.WriteLine("Task 3:");
                    Console.WriteLine("Введите три разных числа");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    n3 = Convert.ToInt32(Console.ReadLine());
                    if (n1 < 0) n1 = 0;
                    if (n2 < 0) n2 = 0;
                    if (n3 < 0) n3 = 0;
                    sum = n1 + n2 + n3;
                    if (sum > 0)
                    {
                        Console.WriteLine($"Сумма положительных чисел: {sum}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Нет положительных чисел");
                        Console.ReadKey();
                    }
                    break;
                    case ("4"):
                    int x;
                    Console.WriteLine("Task 4:");
                    Console.WriteLine("Задайте значение переменной x");
                    x= Convert.ToInt32(Console.ReadLine());
                    if (x > 10) 
                        x *= 2;
                    Console.WriteLine("X= " + x);
                    Console.ReadKey();
                    break;
                    case("5"):
                    string dayOfTheweak;
                    Console.WriteLine("Task 5:");
                    Console.WriteLine("Выберите цифру дня недели от 1 до 7");
                    dayOfTheweak= Console.ReadLine();
                    switch (dayOfTheweak) 
                    {
                        case ("1"):
                            Console.WriteLine("Понедельник");
                            break;
                            case ("2"):
                            Console.WriteLine("Вторник");
                            break;
                            case ("3"):
                            Console.WriteLine("Среда");
                            break;
                            case ("4"):
                            Console.WriteLine("Четверг");
                            break;
                            case("5"):
                            Console.WriteLine("Пятница");
                            break; 
                            case ("6"):
                            Console.WriteLine("Суббота");
                            break;
                            case ("7"):
                            Console.WriteLine("Воскресенье");
                            break;

                    }
                    break;
                    case ("6"):
                    
                    int delitel = 17, num=200;
                    Console.WriteLine("Task 6:");
                    while (true) 
                    {
                        if (num % delitel == 0)
                            break;
                        num++;
                    }
                    Console.WriteLine($"Минимальное число, которое больше 200 и нацело делиться на 17: {num}");
                    Console.ReadKey();
                    break;
                case ("8"):
                    long factorial = 1 , n;
                    Console.WriteLine("Task 8:");
                    Console.WriteLine("Введите факториал, котрый нужно найти");
                    n=Convert.ToInt32(Console.ReadLine());
                    if (n < 0) 
                    {
                        Console.WriteLine("Факториала для отрицательного числа не существует");
                    }
                    else if (n == 0) 
                    { 
                        Console.WriteLine("Факториал 0 равен 1"); 
                    }
                    else 
                    {
                        for(int i=1; i<n+1; i++) 
                        {
                            factorial *= i;
                        }
                        Console.WriteLine($"Факториал {n} равен {factorial}") ;
                    }

                    Console.ReadKey();
                    break;
                case ("9"):
                    int kk;
                    Console.WriteLine("Task 9:");
                    Console.WriteLine("Введите число");
                    kk = Convert.ToInt32(Console.ReadLine());
                     
                    
                    
                        if (kk==1)
                        {
                            Console.WriteLine(" 1 делится только на само себя");
                            Console.ReadKey();

                        }
                        else if (kk < 1) 
                        {
                           Console.WriteLine("У отрицательного числа нет делителей");
                           Console.ReadKey();
                        }
                        else 
                        {
                            bool found = false;
                            for(int i=2; i< kk; i++) 
                            {
                                if (kk % i == 0) 
                                {
                                    Console.WriteLine($"Наименьший делитель числа {kk}равняется {i}" );
                                    Console.ReadKey();
                                found = true;
                                    break;
                                }

                            }
                            if (!found) 
                            {
                                Console.WriteLine($"Число {kk} простое и не имеет делителй кроме 1 и самого себя ");
                                Console.ReadKey();
                            }
                        }
                        break;
            }
        }
    }
}
