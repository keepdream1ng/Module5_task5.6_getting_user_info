namespace Module5_task5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetValidBool());
            //var check = IsItValidBool(Console.ReadLine(), out bool result);
            //int input = GetValidNum();
            //string input = GetValidString();
            //Console.WriteLine(input);
            //Console.WriteLine($"проверка:{check} результат:{result}");
            //Console.WriteLine(IsItValidNum(Console.ReadLine()));
        }

        // to do 
        // +IsItValidString
        // +GetValidString
        // +IsItValidNum
        // +GetValidNum
        // +IsItValidBool
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

        // This method repeats input until it is valid number.
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

        // This method checks different answers as a bool and outputs result if there is one.
        static bool IsItValidBool(string str, out bool output)
        {
            switch (str)
            {
                case "true":
                case "yes":
                case "Yes":
                case "yep":
                case "yas":
                case "да":
                case "Да":
                case "aга":
                case "Ага":
                    {
                        output = true;
                        return true;
                    }
                case "false": 
                case "no": 
                case "No": 
                case "nope": 
                case "нет": 
                case "Нет": 
                case "неа": 
                    {
                        output = false;
                        return true;
                    }
                default: ;
                    {
                        output = false;
                        return false;
                    }
            }
        }

        // This method repeats input until it is valid bool.
        static bool GetValidBool()
        {
            string input;
            bool output;
            
            while (true)
            {
                input = Console.ReadLine();
                if (IsItValidBool(input, out output)) return output;
                Console.WriteLine("Please type yes/no answer correctly/ Пожалуйста введите да или нет");
            }
        }
    }
}