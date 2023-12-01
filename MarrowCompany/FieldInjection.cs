namespace MarrowCompany;

internal static class FieldInjection
{
    public static void Inject()
    {
        FieldInjector.SerialisationHandler.Inject<AmazonDelivery>();
        FieldInjector.SerialisationHandler.Inject<TimeManager>();
        FieldInjector.SerialisationHandler.Inject<Shop>();
    }
}