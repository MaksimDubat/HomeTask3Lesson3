
namespace homework12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var login = string.Empty;
            var password = string.Empty;
            var user = new User(login, password);
            while (true)
            {
                Console.WriteLine("Регистрация:\n" +
                    "1. Ввод логина.\n" +
                    "2. Ввод пароля. \n" +
                    "3. Сохранить\n" +
                    "4. Авторизация\n"+
                    "0. Выход");
                var choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":

                        try
                        {
                            Console.WriteLine("Введите логин");
                            login = Console.ReadLine();
                            user.LoginInput(login);
                        }
                        catch (WrongLoginException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "2":
                        try
                        {
                            Console.WriteLine("Введите пароль");
                            password = Console.ReadLine();
                            user.PasswordInput(password);

                        }
                        catch (WrongPasswordException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "3":
                        try
                        {
                            user.SaveUser(login, password);
                        }
                        catch (Exception ex) 
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "4":
                        try
                        {
                            user.Autorization(login);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "0":
                    default:
                        break;

                }
            } 
        }
    }
}