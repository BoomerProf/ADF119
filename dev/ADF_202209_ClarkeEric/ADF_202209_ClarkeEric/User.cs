using System;
namespace ADF_202209_ClarkeEric
{
    public class User
    {

        private string Name { get; set; }
        private int Id { get; set; }
        private string Password { set; get; }
        Validation validation;

        public User()
        {
        }

        public User(string name, int id, string password)
        {
            this.Name = name;
            this.Id = id;
            this.Password = password;
        }

        public bool Login(User user)
        {
            Console.Clear();
            Console.WriteLine("Please type in your id");
            string idString = Console.ReadLine();
            this.Id = validation.ValidateInt(idString);
            Console.WriteLine("Please type in your password");
            string password = Console.ReadLine();
            this.Password = validation.ValidateString(password);

            if(this.Id == 12345 && this.Password == "password")
            {
                Console.WriteLine("User Found");
                return true; 
            }
            else
            {
                Console.WriteLine("User login not recognized");
                return false;
            }
        }
    }
}
