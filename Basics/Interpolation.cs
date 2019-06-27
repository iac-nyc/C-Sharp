using System;


class Program
{

    // TODO: Defining a Quote method!
   
    public static string Quote(string text)
    {
       
        //string a = "\"" + text + "\"";
        string a = $"\"{ text } \"";


        return a;
    }
   


    static void Main(string[] args)
    {
        // Quote by Maya Angelou.
        Console.WriteLine(Quote("When you learn, teach. When you get, give."));
        // Quote by Benjamin Franklin.
        Console.WriteLine(Quote("No gains without pains."));


    }

}
