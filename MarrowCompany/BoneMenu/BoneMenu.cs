namespace MarrowCompany.Menu;

internal static class BoneMenu
{
    private static int _money;
    public static void Setup()
    {
        MenuCategory mainCat = MenuManager.CreateCategory("Weather Electric", "#6FBDFF");
        MenuCategory subCat = mainCat.CreateCategory("Marrow Company", Color.red);
#if DEBUG
        MenuCategory debugCat = mainCat.CreateCategory("Debug", Color.green);
        debugCat.CreateIntElement("Money", Color.white, 1, 1, 1, 100, v => _money = v);
        debugCat.CreateFunctionElement("Add Money", Color.white, () => SaveManager.IncrementField(JsonField.Money, _money));
        debugCat.CreateFunctionElement("Show Money", Color.white, () =>
        {
            var notification = new Notification()
            {
                Title = "Money",
                Message = $"You have {_money} money!",
                Type = NotificationType.Information,
                PopupLength = 2f,
                ShowTitleOnPopup = true
            };
            Notifier.Send(notification);
        });
#endif
    }
}