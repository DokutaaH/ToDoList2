using ToDoList2.CLI.Models;
using ToDoList2.CLI.Storages;

namespace ToDoList2.CLI.Operations
{
    public class CreateNewUserOperation : IOperation
    {
        public string Name => "Create new user";

        public void Execute()
        {
            Console.Write("Enter your email: ");
            string? email = Console.ReadLine();

            User newUser = new User
            {
                Email = email
            };

            UserStorage.Create(newUser);

            Console.WriteLine("User successfully created");
        }
    }
}
