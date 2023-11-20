using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;
using System.Runtime.Remoting.Services;
using System.Runtime.InteropServices;
using System.Threading;
using System.Security;
using System.Collections;

namespace ConsoleApp8
{
    internal class Program
    {

        //Exrecice 1

        //Task 1,2
        /* static void Func()
         {
             double x, y;
              x = 10;

             y=Math.Pow(x,2);
             Console.WriteLine(y);   

         }


         static void Main(string[] args)
         {

            int n,i;
             Console.WriteLine("Enter n = ");
             n=int.Parse(Console.ReadLine());
             for (i = 0; i < n; i++)
             {
                 Func();
             }


         }*/



        //Task 3
        /*static double Func( double x)
        {
            double y;
            y = (3 * x * x + 8 * x - 10) / 15;

            return y;

        }

        static void Main(string[] args)
        {
            double x, c;

            Write("enter x value= ");
            x = int.Parse(Console.ReadLine());

            c = Func(x);
            Console.WriteLine(c);
        }
        */

        //Exercicice 2

        /* static int Sum(int value_1,int value_2)
          {
              return value_1+value_2;
          }

          static void Main(string[] args)
          {
              int a, b,result;
              Write("Enter value_1= ");
              a=int.Parse(Console.ReadLine());    

              Write("Enter value_2= ");
              b=int.Parse(Console.ReadLine());

              result = Sum(a, b);
              Console.WriteLine($" {a} + {b} = "+result);  
          }*/


        //Exercice 3

        /*  static double Func(double x)
          {
              double y = x * x;
              return y;

          }

          static void Main(string[] args)
          {
              int a,b,h;
              Write("Enter primary value=");
              a=int.Parse(Console.ReadLine());

              Write("Enter ended value=");
              b= int.Parse(Console.ReadLine());

              Write("Enter H value= ");
              h= int.Parse(Console.ReadLine());



              for (int i = a; i <= b; i +=h)
              {
                  double res = Func(i);
                  Write($"{i}  !   {res}");
              }
          }
        */

        //Exercice 4

        /*
        static int Func(int x)
        {
            return 5 * (x * x) - 2 * x + 1;
        }
        static void Table()
        {
            for (int i =-5; i <=5; i += 2)
            {
                int res=Func(i);
                WriteLine($"{i}   ///  {res}");
            }

        }
        static void Main(string[] args)
        
        {
            WriteLine("x     //     y");
            Table();
        }

       */

        //exercice 5
        /*  static int Func(int x)
          {
              int y=0 ;


              if (x < 5)
              {
                  y = (4 * (x * x)) / x - 5;
              }
              if (x >= 5)
              {
                  y = 3 * (x * x) - 2;
              }
              return y;

          }
          static void Main(string[] args)
          {
              Write("Enter x =  ");
              int x=int.Parse(Console.ReadLine());

              int res = Func(x);
              Console.WriteLine(res);
          }
          */


        //Exercice 6
       /* static void Main(string[] args)
        {

            Write("Enter int value_1 = ");
            int a = int.Parse(Console.ReadLine());
            Write("Enter  int value_2 = ");

            int b = int.Parse(Console.ReadLine());

            Write("Enter a symbol to manipulate '+' '*' '-' = ");
            char sym = char.Parse(Console.ReadLine());

            int result = Operation(sym, a, b);
            Console.WriteLine(result);

        }

        static int Operation(int op, int a, int b)
        {

            switch (op)
            {
                case '+': return a + b;
                case '*': return a * b;
                case '/': return a / b;

                default: return 0;
            }

        }
       */


        // exercice
        /*
        static double Func(double primarysum,double percent )
        {
            double endsum = primarysum * (1 + (percent / 100));
            return endsum;
        }

        static void Main(string[] args)
        {

            Write("Enter primary  capital= ");
            double primarySum=double.Parse(Console.ReadLine());

            Write("Enter percent in ur capital= ");
            double precent=double.Parse(Console.ReadLine());

            double res=Func(primarySum, precent);

            WriteLine($" primary capital - {primarySum} \t  precent -  {precent}  \t RESULT;{ res}");
        }*/

        // exercice 6.1
       /* static double Func(double value_1,double value_2)
        {
            double result=Math.Max(value_1,value_2);   
            return result;
        }
          static void Main(string[] args)
        {
            Write("val_1= ");
            int a=int.Parse(Console.ReadLine());
            Write("val_2= ");
            int b=int.Parse(Console.ReadLine());

            double res=Func(a,b);
            Console.WriteLine("Max Value= "+res);

        }*/

        //exercice 6.2



       /* static int Func(int val1,int val2,int val3)
        {
            int res=(val1+val2+val3)/3;
            return res;

        }


       static void Main(string[] args)
        {
            

            int []numbers = new int [3];

            for(int i = 0; i < 3; i++)
            {
                Write($"Enter number={i+1} ");
               numbers[i]=int.Parse(Console.ReadLine());
            }
            int end = Func(numbers[0], numbers[1], numbers[2]);  

            Console.WriteLine(end); 

        }*/






        
        static int Func(int x)
        {

            return 4 * (x * x) + 5 * x - 10;

        }
        static void Loop()
        {
            for (int i = -9; i <=9; i+=3)
            {
                double res= Func(i);
                Console.WriteLine($"{res} \t { i }");
            }
        }




       static void Main(string[] args)
        {
            Console.WriteLine("y     //     x");

            Loop();

    
        }

        


       



    }



















}
