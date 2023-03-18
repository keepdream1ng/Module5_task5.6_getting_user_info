namespace Module5_task5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsItValidString(Console.ReadLine()));
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

        static bool IsItValidString(string str)
        {
            return ((str.Length > 0) && (!int.TryParse(str, out int result)));
        }
    }
}