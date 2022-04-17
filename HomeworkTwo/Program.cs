using System.Diagnostics;
using BankAccount;

namespace Homework
{
    public class Program
    {
        public static void Main()
        {
            InteractionWithString str = new();
            string temp = "Кучма";
            str.SearchMail(ref temp);

            Console.WriteLine(temp);

            //string str = InteractionWithString.ReverseString("abcd");
            //Console.WriteLine(str);
            //Console.ReadKey();

            //TestForHomeworkTwo.Start();


        }
    }
}
