namespace MarrowCompany.Menu;

internal static class BoneMenu
{
    public static void Setup()
    {
        MenuCategory mainCat = MenuManager.CreateCategory("Weather Electric", "#6FBDFF");
        MenuCategory subCat = mainCat.CreateCategory("Marrow Company", Color.red);
    }
}