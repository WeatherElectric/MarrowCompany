namespace MarrowCompany.Scripts.Game;

public class Shop : MonoBehaviour
{
    public AmazonDelivery deliveryService;
    public SpawnableCrateReference flashlight;
    public int flashlightCost;
    public SpawnableCrateReference shovel;
    public int shovelCost;

    public void BuyFlashlight()
    {
        if (SaveManager.Money >= flashlightCost)
        {
            SaveManager.DecrementField(JsonField.Money, flashlightCost);
            deliveryService.OrderedCrates.Add(flashlight);
        }
        else
        {
            var notification = new Notification()
            {
                Title = "Not enough money!",
                Message = "You don't have enough money to buy this item!",
                Type = NotificationType.Error,
                PopupLength = 2f,
                ShowTitleOnPopup = true
            };
            Notifier.Send(notification);
        }
    }

    public void BuyShovel()
    {
        if (SaveManager.Money >= shovelCost)
        {
            SaveManager.DecrementField(JsonField.Money, shovelCost);
            deliveryService.OrderedCrates.Add(shovel);
        }
        else
        {
            var notification = new Notification()
            {
                Title = "Not enough money!",
                Message = "You don't have enough money to buy this item!",
                Type = NotificationType.Error,
                PopupLength = 2f,
                ShowTitleOnPopup = true
            };
            Notifier.Send(notification);
        }
    }
}