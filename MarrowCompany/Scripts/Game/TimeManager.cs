namespace MarrowCompany.Scripts.Game;

public class TimeManager : MonoBehaviour
{
    public AmazonDelivery deliveryService;
    public float secondsPerMinute = 5f;
    private float _time = 8 * 60;
    
    private void Update()
    {
        _time += Time.deltaTime / secondsPerMinute;
        if (Mathf.Floor(_time) % 60 == 0)
        {
            deliveryService.Deliver();
        }
        if (_time >= 24 * 60)
        {
            _time = 0;
        }
    }
}