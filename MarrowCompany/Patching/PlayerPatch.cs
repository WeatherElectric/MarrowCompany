namespace MarrowCompany.Patching;

[HarmonyPatch(typeof(Player_Health), "MakeVignette")]
public static class VignettePatch
{
    public static void Postfix(Player_Health __instance)
    {
        var invoke = UnityEngine.Object.FindObjectOfType<OnPlayerReady>();
        if (invoke != null)
        {
            invoke.Ready();
        }
    }
}