namespace Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("user","user@gmail.com");

            user.PasswordChecker("dggargd1223");

            user.ShowInfo();
        }
    }
}
