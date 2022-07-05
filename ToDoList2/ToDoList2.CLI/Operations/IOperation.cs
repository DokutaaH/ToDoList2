namespace ToDoList2.CLI.Operations
{
    public interface IOperation
    {
        public string Name { get; }

        void Execute();
    }
}
