namespace MarrowCompany.Melon;

internal static class UserData
{
    private static readonly string WeatherElectricPath = Path.Combine(MelonUtils.UserDataDirectory, "/Weather Electric");
    private static readonly string ModPath = Path.Combine(MelonUtils.UserDataDirectory, "/Weather Electric/Marrow Company");
    public static readonly string SaveFile = Path.Combine(MelonUtils.UserDataDirectory, "/Weather Electric/Marrow Company/Save.json");

    public static void Setup()
    {
        if (!Directory.Exists(WeatherElectricPath))
        {
            Directory.CreateDirectory(WeatherElectricPath);
        }
        if (!Directory.Exists(ModPath))
        {
            Directory.CreateDirectory(ModPath);
        }
        if (!File.Exists(SaveFile))
        {
            var file = HelperMethods.GetResourceBytes(Main.CurrAssembly, "MarrowCompany.Resources.Save.json");
            File.WriteAllBytes(SaveFile, file);
        }
    }
}