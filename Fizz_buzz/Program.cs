using System;

namespace Fizz_buzz
{
    
    class Program
    {
   
        static void Main(string[] args)
        {
                    Console.WriteLine("Fizz Buzz Program");
                    Console.WriteLine("");
                    string f= "Fizz";
                    string b= "Buzz";
                    Console.WriteLine("Rule 1: if the number is multiple of 3 prints: "+f);
                    Console.WriteLine("Rule 2: if the number is multiple of 3 prints: "+b);
                    Console.WriteLine("");

                for(int i = 1; i <= 100; i++)
                {
                    string r="";


                    if(i % 3 == 0) 
                    r="Fizz";

                    if(i % 5 == 0)
                    r="Buzz";
                    
                    if(r.Length==0)
                    r=i.ToString();

                    Console.WriteLine(r);
                }
           
        }
    }
}
