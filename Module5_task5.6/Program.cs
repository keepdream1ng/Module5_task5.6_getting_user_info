namespace Module5_task5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var UserUnfo = GetUserInfo();
            PrintUserInfo(UserUnfo);
        }

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

        // This method puts user input in a array based of passed lenght and guides user via the message.
        static string[] GetArrayFromConsole(int lenght, string message = "Insert data/ Введите данные")
        {
            string[] input = new string[lenght];

            for (int i = 0; i < lenght; i++) 
            {
                Console.WriteLine($"{message} {i + 1}");
                input[i] = GetValidString();
            }
            return input;
        }

        // This method returns tuple with the user info input.
        static (string Name, string LastName, int age, bool havePet, string[] pets, int coloursNum, string[] favColours) GetUserInfo()
        {
            // I had to declare a whole empty tuple first, seems like the object would be easier, but i havent worked with them before.
            (string Name, string LastName, int age, bool havePet, string[] pets, int coloursNum, string[] favColours) User =
                (string.Empty, string.Empty, 1, false, Array.Empty<string>(), 1, Array.Empty<string>()); 

            Console.WriteLine("Enter your name/ Введите свое имя");
            User.Name = GetValidString();
            
            Console.WriteLine("Enter your lastname/ Введите свою фамилию");
            User.LastName = GetValidString();

            Console.WriteLine("Enter your age/ Введите свой возраст");
            User.age = GetValidNum();

            Console.WriteLine("Do you have a pet?/ У вас есть питомец?");
            User.havePet = GetValidBool();

            if (User.havePet)
            {
                Console.WriteLine("How many pets do you have?/ Сколько у вас питомцев?");
                int petsNum = GetValidNum();
                User.pets = GetArrayFromConsole(petsNum, "Enter name of a pet/ Введите имя питомца");
            }

            Console.WriteLine("How many favorite colours do you have?/ Сколько у тебя любимых цветов?");
            User.coloursNum = GetValidNum();
            User.favColours = GetArrayFromConsole(User.coloursNum, "Insert colour/ Введите цвет");

            return User;
        }

        static void PrintArray(string[] arr)
        {
            foreach (string item in arr) Console.WriteLine(item);
        }

        // This method prints tuple with the user info.
        static void PrintUserInfo((string Name, string LastName, int age, bool havePet, string[] pets, int coloursNum, string[] favColours) UserInfo)
        {
            Console.WriteLine();
            Console.WriteLine($"First Name / Имя      | {UserInfo.Name,15}");
            Console.WriteLine($"Last Name / Фамилия   | {UserInfo.LastName,15}");
            Console.WriteLine($"Age / Возраст         | {UserInfo.age,15}");
            if (UserInfo.havePet)
            {
                Console.WriteLine("\nPet names/ Клички питомцев");
                PrintArray(UserInfo.pets);
            }
            Console.WriteLine("\n Favorite colours/ Любимые цвета");
            PrintArray(UserInfo.favColours);
        }
    }
}