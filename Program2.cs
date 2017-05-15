using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace C____lab2
{
    
    class Program
    {
        static void Main(string[] args)
        {
		/*  //задание 2.1 (шахматы)
            char a = '+', b = '-';
            Console.WriteLine("Введите n*n размерность доски");
            int n = int.Parse(Console.ReadLine());            
            z1: for (int i = 1; i <= n; ++i, Console.WriteLine())     //1
                  for (int j = 1; j <= n; ++j)
                    if ( (i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0) ) Console.Write(" "+a);
                    else Console.Write(" "+b);

            zadanie:  Console.Write("Введите № задания: ");
            char oper = char.Parse(Console.ReadLine());              
                
            switch (oper)
                {
                case '1': 

                    int t=0;
                    for (int i = 1; i <= n; ++i)     
                      for (int j = 1; j <= n; ++j)
                         if ((i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0)) t++;
                    Console.WriteLine(t);
                    goto zadanie;   

                case '2': 
                    Console.WriteLine("Введите строку");
                    int k = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите столбец");
                    int m = int.Parse(Console.ReadLine());
                    string t2 = " ";
                    for (int i = 1; i <= k; ++i)     
                      for (int j = 1; j <= m; ++j)
                        if ((i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0)) t2 = "Черная";
                        else t2 = "Белая";                           
                    Console.WriteLine(t2);
                    goto zadanie;
                         
                case '3':
                    string o1 = " ", o2 = " ", o = " ";
                    
                    Console.WriteLine("Введите строку");
                    int k1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите столбец");
                    int m1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите строку");
                    int k2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите столбец");
                    int m2 = int.Parse(Console.ReadLine());
                    
                    for (int i = 1; i <= k1; ++i)     
                      for (int j = 1; j <= m1; ++j)
                          if ((i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0)) o1 = "Черная";
                          else o1 = "Белая";

                    for (int i = 1; i <= k2; ++i)     
                      for (int j = 1; j <= m2; ++j)
                          if ((i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0)) o2 = "Черная";
                          else o2 = "Белая";
                    
                    if (o1==o2) o="Одного цвета";
                    else o="Разного цвета";

                    Console.WriteLine(o);
                    goto zadanie;
                 }*/

/////////////////////////////задание 2.1.4//////////////////////////////////////////////////
                    //case '4': 
            /*        
            zadanie4:  Console.Write("Введите № задания: ");
            char oper = char.Parse(Console.ReadLine());

            switch (oper)
            {
                case '1': //конь// 
                    Console.WriteLine("Введите строку фигуры 1");
                    int k11 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите столбец фигуры 1");
                    int k12 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите строку фигуры 2");
                    int m11 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите столбец фигуры 2");
                    int m12 = int.Parse(Console.ReadLine());

                    if ((Math.Abs(k11 - m11) == 2) && (Math.Abs(k12 - m12) == 1) || (Math.Abs(k11 - m11) == 1) && (Math.Abs(k12 - m12) == 2))
                        Console.WriteLine("конь Бъет!");
                    else
                        Console.WriteLine("конь НЕ Бъет!");
                    goto zadanie4;
                case '2': //ладья// 
                    Console.WriteLine("Введите строку фигуры 1");
                    int k21 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите столбец фигуры 1");
                    int k22 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите строку фигуры 2");
                    int m21 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите столбец фигуры 2");
                    int m22 = int.Parse(Console.ReadLine());
                    if (Math.Abs(k21 - m21) == Math.Abs(k22 - m22))
                        Console.WriteLine("ладья Бъет!");
                    else
                        Console.WriteLine("ладья НЕ Бъет!");
                    goto zadanie4;
                case '3': //слон// 
                    Console.WriteLine("Введите строку фигуры 1");
                    int k31 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите столбец фигуры 1");
                    int k32 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите строку фигуры 2");
                    int m31 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите столбец фигуры 2");
                    int m32 = int.Parse(Console.ReadLine());

                    if (k31 == m31 || k32 == m32)
                        Console.WriteLine("слон Бъет!");
                    else
                        Console.WriteLine("слон НЕ Бъет!");
                    goto zadanie4;
                case '4': //ферзь// 
                    Console.WriteLine("Введите строку фигуры 1");
                    int k41 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите столбец фигуры 1");
                    int k42 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите строку фигуры 2");
                    int m41 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите столбец фигуры 2");
                    int m42 = int.Parse(Console.ReadLine());

                    if ((k41 == m41 && k42 == m42) || (k41 == m41 || k42 == m42 || Math.Abs(k41 - m41) == Math.Abs(k42 - m42)))
                        Console.WriteLine("Ферзь бъет!");
                    else
                        Console.WriteLine("Ферзь НЕ бъет!");
                    goto zadanie4;
            }
            */    
            
           
//////////////////////задание 2.2///////////////////////
           /* int[] mon = new int[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.WriteLine("Введите месяц");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите день");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год");
            int z = int.Parse(Console.ReadLine());
            string a = Convert.ToString(y);
            string b = Convert.ToString(x);
            string c = Convert.ToString(z);
            string d = a + '.' + b + '.' + c;

            Console.WriteLine(a);
            int m = 0, n = 0, i = 0;
            while (i <= x) //Задание 2.2.1 (Считает от начала года)
            {
                m += mon[i];
                i++;
            }
            m += y;
            m -= mon[x];

            n = 365 - m;//Задание 2.2.2 (Считает до конца года)

            Console.WriteLine("1) Прошло: " + m + " д. от начала года ");
            Console.WriteLine("2) Осталось: " + n + " д. до конца года ");
            
                //Задание 2.2.3 предыдущий// 
            var date1 = DateTime.Parse(d, new CultureInfo("Ru-ru")).AddDays(-1);
            Console.WriteLine("3) Дата предыдущего дня: "+string.Format(new CultureInfo("Ru-ru"), "{0:d}", date1));

                //Задание 2.2.4 следующий//                 
            var date2 = DateTime.Parse(d, new CultureInfo("Ru-ru")).AddDays(1);
            Console.WriteLine("4) Дата следующего дня: "+string.Format(new CultureInfo("Ru-ru"), "{0:d}", date2));
			*/



            
   ////////////////задание 2.3////////////////////////////////////////
        /*    Console.WriteLine("все трехзначные числа Армстронга:");
            for(int i=100;i<=999;i++)
                {
                    int a=i%10;
                    int b=(i/10)%10;
                    int c=(i/100)%10;
                    int tmp=a*a*a+b*b*b+c*c*c;
                    if(i==tmp)
                    {
                        Console.WriteLine(i);
                    }
                } */
             
   ////////////////задание 2.4////////////////////////////////////////
      /*    Console.WriteLine("Введите сторону а");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b");
            int b = int.Parse(Console.ReadLine());
            int i = 0, m = 0;
            m = a*b;
            while (a != b) { 
                if (a>b)
                {
                    a -= b;
                    i++;
                }
                else if (b > a) {
                    b -= a;
                    i++;
                }
            } i++;
            
            Console.WriteLine("кол-во квадратов наименьшей площади: " + m);
            Console.WriteLine("кол-во квадратов наибольшей площади: " + i);     */

        }
    }
}

