namespace PDF4Dev.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static PDF4DevClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("PDF4DEV_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("PDF4DEV_API_KEY environment variable is not found.");

        var client = new PDF4DevClient(apiKey);
        
        return client;
    }
}
