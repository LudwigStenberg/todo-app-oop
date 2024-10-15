namespace todo_app_oop;

public class HelpCommand : Command
{
    public HelpCommand(string name, Program program)
        : base("help", program) { }

    public override void Execute(string[] commandArgs)
    {
        Console.WriteLine("");
    }
}
