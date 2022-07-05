using ToDoList2.CLI;
using ToDoList2.CLI.Operations;

IOperation[] operations = new IOperation[]
{
    new CreateNewUserOperation(),
    new LoginUserOperation(),
};
Menu menu = new Menu(operations);
Application application = new Application(menu);
application.Run();