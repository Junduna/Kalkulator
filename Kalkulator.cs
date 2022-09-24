using System;
namespace TechnicalProjectAssigment
{
    class Kalkulator
    {
        public static void Main(String[] args)
        { 
        float Res;    
        Console.WriteLine("Enter the action to be performed");
        Console.WriteLine("Press 1 for Additional");
        Console.WriteLine("Press 2 for Subtraction");
        Console.WriteLine("Press 3 for Multiplication");
        Console.WriteLine("Press 4 for Division");
        int pilihan = int.Parse(Console.ReadLine());

        Console.Write("Enter 1st input :");
        int a  = int.Parse(Console.ReadLine());
        Console.Write("Enter 2nd input :");
        int b = int.Parse(Console.ReadLine());
        
        switch (pilihan)
        {
            case 1:
                Res = a + b;
                Console.WriteLine("The result is "+Additional(a, b));
                break;
            case 2:
                Res = a - b;
                Console.WriteLine("The result is "+Subtraction(a, b));
                break;
            case 3:
                Res = a * b;
                Console.WriteLine("The result is "+Multiplication(a, b));
                break;
            case 4:
                Res = a / b;
                Console.WriteLine("The result is "+Division(a, b));
                break;
            default :
                Console.WriteLine("Your Choice was invalid!"); break;
        }
        Console.ReadKey();


        }
        static int Additional(int a, int b){
            return a+b;
        }
        static int Subtraction(int a, int b){
            return a-b;
        }
        static int Multiplication(int a, int b){
            return a*b;
        }
        static int Division(int a, int b){
            return a/b;
        }
    }
}