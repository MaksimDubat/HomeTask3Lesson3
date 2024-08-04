
namespace homework12
{
    internal class User
    {
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty; 
        

        public User(string Login, string Password) 
        {
            this.Login = Login;
            this.Password = Password;
        }
        public void LoginInput(string Login)
        {
            if (Login.Length > 20)
                throw new WrongLoginException(Login, "Логин должен содержать не более 20 символов");
            else if (string.IsNullOrWhiteSpace(Login))
                throw new WrongLoginException(Login, "Логин пуст");
            else if (Login.Contains(" "))
                throw new WrongLoginException(Login, "Логин содержит пробелы");
        }
        public void PasswordInput(string Password)
        {
            if (Password.Length > 20)
                throw new WrongPasswordException(Password, "Пароль должен содержать не более 20 символов");
            else if (Password.Contains(" "))
                throw new WrongPasswordException(Password, "Пароль содержит пробелы");
            else if (Password == string.Empty)
                throw new WrongPasswordException(Password, "Пароль пуст");
            var proto = ' ';
            foreach (var num in Password)
                if (char.IsDigit(num))
                {
                    proto = num;
                }
            if (!char.IsDigit(proto))
                throw new WrongPasswordException(Password, "пароль не содержит цифр");

        }
        public void SaveUser(string _login, string _password)
        {
            using (StreamWriter sw = new StreamWriter("F:\\users.txt", true))
            {
                sw.WriteLine("Добавлен новый пользователь");
                sw.WriteLine(_login);
                sw.WriteLine(_password);
                sw.Close();
                Console.WriteLine("пользователь успешно сохранен");
            }
            
        }
        public bool Autorization(string login)
        {
            using (StreamReader sr = new StreamReader("F:\\users.txt")) 
            {
                string _login = sr.ReadToEnd();
                Console.WriteLine("введите логин");
                login = Console.ReadLine();
                while (_login != null )
                {
                    if (_login.Contains(login)) 
                    {
                        Console.WriteLine("ok");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("нет пользователя c таким логином, зарегистрируйтесь)");
                        return false;
                    }

                }
                return true;
            }
        }
    }
}
