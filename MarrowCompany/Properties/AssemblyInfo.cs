using System.Reflection;

[assembly: AssemblyTitle(MarrowCompany.Main.Description)]
[assembly: AssemblyDescription(MarrowCompany.Main.Description)]
[assembly: AssemblyCompany(MarrowCompany.Main.Company)]
[assembly: AssemblyProduct(MarrowCompany.Main.Name)]
[assembly: AssemblyCopyright("Developed by " + MarrowCompany.Main.Author)]
[assembly: AssemblyTrademark(MarrowCompany.Main.Company)]
[assembly: AssemblyVersion(MarrowCompany.Main.Version)]
[assembly: AssemblyFileVersion(MarrowCompany.Main.Version)]
[assembly:
    MelonInfo(typeof(MarrowCompany.Main), MarrowCompany.Main.Name, MarrowCompany.Main.Version,
        MarrowCompany.Main.Author, MarrowCompany.Main.DownloadLink)]
[assembly: MelonColor(System.ConsoleColor.White)]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]