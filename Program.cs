using System;
using func;
namespace Program {
    class BasicLearning{
         public static void Main(String[] args)
        {
            Calculator b=new Calculator();

            Console.WriteLine("Enter two numbers:");
            double one=0;
            double.TryParse(Console.ReadLine(),out one);
            double two=0;
            double.TryParse(Console.ReadLine(),out two);
            Console.WriteLine("Enter your choice 1=ADD, 2=SUBTRACT, 3=MULTIPLY, 4=DIVIDE");
            int choice=Convert.ToInt32(Console.ReadLine());
            
            switch(choice)
            {
                case 1:
                {
                    b.Add(one,two);
                    break;
                }
                case 2:
                {
                    b.Subtract(one,two);
                    break;
                }
                case 3:
                {
                    b.Multiply(one,two);
                    break;
                }
                case 4:
                {
                    b.Divide(one,two);
                    break;
                }
                default:
                {
                    Console.WriteLine("Select appropriate option");
                    break;
                }

            }
        }
    }
}