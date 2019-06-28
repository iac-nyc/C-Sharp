using System;


class Program
{
    // TODO: Define a Divide method! Casting.
    static double Divide(int dividend, int divisor)
    {

        var x = (double)dividend;
        var y = (double)divisor;

        return x / y;

    }


    static void Main(string[] args)
    {
       
        // This should print "2.5".
        Console.WriteLine(Divide(5, 2));
        // This should print "3.3333333333..."
        // (Or a value close to that, since it can't be
        // infinitely precise.)
        Console.WriteLine(Divide(10, 3));


    }

}
