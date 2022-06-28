using System;

namespace Type_5_Default_parameter
{
    class Program
    {
       static void show(int num,int num1,char choice = '+')
        {
            if (choice=='+')
            {
                Console.WriteLine("Sum :"+(num+num1));
            }
            else if (choice=='-')
            {
                Console.WriteLine( num - num1);
            }
            else
            {
                Console.WriteLine("Not found :");
            }
        }
        static void Main(string[] args)
        {
            show(10, 20);
        }
    }
}
