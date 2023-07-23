//Write a program to explain get set accessor.

namespace Lab_6q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           getSet s1 = new getSet();
            Console.WriteLine("Enter your Name: ");
            s1.name = Console.ReadLine();
            Console.WriteLine("Set your Password: ");
            string s2 = Console.ReadLine();
            s1.setting(s2);
            Console.WriteLine("your name is {0} and Your new Password is {1}.",s1.name,s1.getting());
        }
    }
}