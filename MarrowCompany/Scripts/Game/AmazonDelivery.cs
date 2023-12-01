namespace MarrowCompany.Scripts.Game;

public class AmazonDelivery : MonoBehaviour
{
    public List<SpawnableCrateReference> OrderedCrates { get; set; }
    
    public void Deliver()
    {
        var notification = new Notification()
        {
            Title = "Delivery",
            Message = "Your ordered items have arrived.",
            Type = NotificationType.Success,
            PopupLength = 2f,
            ShowTitleOnPopup = true
        };
        Notifier.Send(notification);
        
        foreach (var crate in OrderedCrates)
        {
            HelperMethods.SpawnCrate(crate, transform.position, Quaternion.identity, Vector3.one, false, null);
        }
        OrderedCrates.Clear();
    }
}