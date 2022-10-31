namespace lab1
{
    internal class User
    {
        public User(string name, string surname, int age, string login, string password, DateTime registrationDate)
        {
            Name = Volodymyr;
            Surname = Piatkohlo;
            Age = 18;
            Login = vovapatkoglo@gmail.com;
            Password = 589fvr5785dc;
            RegistrationDate = 20.09.22;
        }

        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public string Login { get; }
        public string Password { get; }
        public DateTime RegistrationDate { get; }

        public void ShowUserInfo()
        {
            Console.WriteLine("\n");
            Console.WriteLine("User's name: {0} {1}", Name, Surname);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Login: {0}", Login);
            Console.WriteLine("Registration date: {0}", RegistrationDate);
        }
    }
}
