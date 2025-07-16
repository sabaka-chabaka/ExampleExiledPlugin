using Exiled.API.Features;

namespace ExamplePlugin;

public class Plugin : Plugin<Config>
{
    public override string Name => "Plugin";
    public override string Author => "Author";
    public override string Prefix => "Plugin";
    public override Version Version => new Version(1, 0, 0);
    
    public override void OnEnabled()
    {
        base.OnEnabled();
    }
    
    public override void OnDisabled()
    {
        base.OnDisabled();
    }
}