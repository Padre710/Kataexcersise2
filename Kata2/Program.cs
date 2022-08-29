using System;

//Jaden Smith, the son of Will Smith, is the star of films such
//as The Karate Kid (2010) and After Earth (2013). 
//Jaden is also known for some of his philosophy that he delivers via Twitter.When writing on Twitter,
//he is known for almost always capitalizing every word.For simplicity,
//you'll have to capitalize each word, 
//check out how contractions are expected to be in the example below.
//Your task is to convert strings to how they would be written by Jaden Smith.
//The strings are actual quotes from Jaden Smith,
//but they are not capitalized in the same way he originally typed them.

//Example:
//Not Jaden - Cased: "How can mirrors be real if our eyes aren't real"
//Jaden -Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"

namespace Kata2
{  
    public static class JadenCase
    {
        
        

        public static string ToJadenCase(this string phrase)
        {
            int i;
            char w;
            const char V = ' ';
            Console.WriteLine(phrase.Length);
            string edited = string.Empty;
            

            for (i = 0; i < phrase.Length; i++)
            {
                 if (i == 0)
                {
                    w = char.ToUpper(phrase[0]);
                    edited += w;
                }
               else if ( i!= 0 && phrase[i-1] == V )
                {
                   w =  char.ToUpper(phrase[i]);
                    edited += w;
                }
                
                else
                edited += phrase[i];
            }
           
           Console.WriteLine(edited);
            return edited;
            // FOR SOME REASON, MY FUNCTION IS NOT RETURNING, HENCE I'M USING THE WRITELINE INSTEAD
            // WE SHOULD FIND A SOLUTION FOR THAT.
        }
    }
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             JadenCase.ToJadenCase("how can mirrors be real if our eyes aren't real");
           
        }
    }
}
