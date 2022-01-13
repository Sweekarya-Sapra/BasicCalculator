using System;

namespace func;
class Calculator
{
    public void Add ( double c, double d )
        {
            c+=d;
            Console.WriteLine("Result is: "+c);
        }
        public void Subtract ( double c, double d )
        {
            c-=d;
            Console.WriteLine("Result is: "+c);
        }
        public void Multiply ( double c, double d )
        {
            c*=d;
            Console.WriteLine("Result is: "+c);
        }
        public void Divide ( double c, double d )
        {
            c/=d;
            Console.WriteLine("Result is: "+c);
        }
}