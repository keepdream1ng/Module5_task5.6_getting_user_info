namespace Module5_task5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = GetValidSting();
            Console.WriteLine(input);
            //Console.WriteLine(IsItValidString(Console.ReadLine()));
        }

        // to do 
        // IsItValidString
        // GetValidString
        // IsItValidNum
        // GetValidNum
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
        static string GetValidSting()
        {
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (IsItValidString(input)) return input;
                Console.WriteLine("Please type correct value/ Пожалуйста введите корректное значение");
            }
        }
    }
}