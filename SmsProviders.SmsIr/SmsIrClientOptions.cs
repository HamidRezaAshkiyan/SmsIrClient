namespace SmsProviders.SmsIr;

public class SmsIrClientOptions
{
    public const string ConfigurationSection =
        nameof(SmsIrClientOptions);

    public string BaseAddress { get; init; }
    public string ApiKey { get; init; }
}