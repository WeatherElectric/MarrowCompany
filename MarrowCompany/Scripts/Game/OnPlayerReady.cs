namespace MarrowCompany.Scripts.Game;

public class OnPlayerReady : MonoBehaviour
{
    public UltEvent onReady;
    
    public void Ready()
    {
        onReady.Invoke();
    }
    
    public OnPlayerReady(IntPtr ptr) : base(ptr) {}
}