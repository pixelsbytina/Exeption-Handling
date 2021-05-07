using System;
class ExeptionHandling
{
    static void Main()
    {
        try
        {
            /*user input*/
            Console.Write("Enter a number between 0 and 255: ");
            string first = Console.ReadLine();
            Console.Write("Enter another number between 0 and 255: ");
            string second = Console.ReadLine();
            /*output*/
            Console.WriteLine("{0} divided by {1} is {2}", first, second, Int32.Parse(first) / Int32.Parse(second));
        }
        catch (Exception e)
        {
            /*exception*/
            Console.WriteLine("{0}: Input string was not in a correct format.", e.GetType().Name);
        }
    }
}