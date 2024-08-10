using CounterStrikeSharp.API.Core;
namespace HelloWorldPlugin;

public class HelloWorldPlugin : BasePlugin
{
    public override string ModuleName => "Hello World Plugin";

    public override string ModuleVersion => "0.0.1";

    public override void Load(bool notReload){
        Console.WriteLine("Hello World!");
    }
}
