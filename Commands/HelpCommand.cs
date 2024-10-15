namespace todo_app_oop;

public class HelpCommand : Command
{
    public HelpCommand(string name, Program program) : base(name, program)
    {
    }

    public override void Execute(string[] commandArgs)
    {
        throw new NotImplementedException();
    }
}
