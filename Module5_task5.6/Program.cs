using System.Xml.XPath;

namespace Module5_task5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = GetValidNum();
            //string input = GetValidString();
            Console.WriteLine(input);
            //Console.WriteLine(IsItValidNum(Console.ReadLine()));
        }

        // to do 
        // +IsItValidString
        // +GetValidString
        // +IsItValidNum
        // +GetValidNum
        // IsItValidBool
        // GetValidBool
        // GetStrArrayFromConsole
        // GetUserInfo
        // PrintUserInfo

        // This method checks if string is not a number and has some lenght.
        static bool IsItValidString(string str)
        {
            return ((str.Length > 0) && (!int.TryParse(str, out int result)));
        }

        // This method repeats input until it is valid.
        static string GetValidString()
        {
            string input;

            while (true)
            {
                input = Console.ReadLine();
                if (IsItValidString(input)) return input;
                Console.WriteLine("Please type correct value/ Пожалуйста введите корректное значение");
            }
        }

        // This method checks if input is number and 0 is'nt an option.
        static bool IsItValidNum(string str, out int output)
        {
            output = 1;
            // output will be rewritten at least if the check is passed.
            return ((str.Length > 0) && (int.TryParse(str, out output) && (output > 0)));
        }

        // This method repeats intup until it is valid number.
        static int GetValidNum()
        {
            string input;
            int output;

            while (true)
            {
                input = Console.ReadLine();
                if (IsItValidNum(input, out output)) return output;
                Console.WriteLine("Please type correct number/ Пожалуйста введите корректное значение числа");
            }
            
        }
    }
}