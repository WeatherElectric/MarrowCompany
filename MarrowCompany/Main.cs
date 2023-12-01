using System.Reflection;

namespace MarrowCompany;

public class Main : MelonMod
{
    internal const string Name = "Marrow Company";
    internal const string Description = "A remake of Lethal Company for BONELAB";
    internal const string Author = "SoulWithMae";
    internal const string Company = "Weather Electric";
    internal const string Version = "0.0.1";
    internal const string DownloadLink = null;
    
    internal static Assembly CurrAssembly => Assembly.GetExecutingAssembly();

    public override void OnInitializeMelon()
    {
        ModConsole.Setup(LoggerInstance);
        Preferences.Setup();
        BoneMenu.Setup();
        UserData.Setup();
        SaveManager.LoadSave();
        FieldInjection.Inject();
        Hooking.OnLevelInitialized += OnLevelLoad;
        Hooking.OnLevelUnloaded += OnLevelUnload;
    }

    private static void OnLevelLoad(LevelInfo levelInfo)
    {
        
    }

    private static void OnLevelUnload()
    {
        
    }
}