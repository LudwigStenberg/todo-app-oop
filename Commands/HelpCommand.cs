public class HelpCommand : Command
{
    public HelpCommand(Program program)
        : base("help", program) { }

    public override void Execute(string[] commandArgs)
    {
        Console.Clear();
        Console.WriteLine("List of commands: ");
        Console.WriteLine("create-task <title>");
        Console.WriteLine("remove-task <title>");
        Console.WriteLine("search-task <title>");
    }
}
