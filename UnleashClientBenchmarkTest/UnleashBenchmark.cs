using BenchmarkDotNet.Attributes;
using Unleash;
using Unleash.ClientFactory;
using Unleash.Internal;

namespace UnleashClientBenchmarkTest;

[MemoryDiagnoser]
public class UnleashBenchmark
{
    private IUnleash _unleash;
    private UnleashContext _context;
    private const string ToggleName = "test-toggle";
    private const string VariantName = "variant-toggle";

    [GlobalSetup]
    public void Setup()
    {
        var unleashSettings = new UnleashSettings
        {
            AppName = "MYG",
            UnleashApi = new Uri(""),
            CustomHttpHeaders = new Dictionary<string, string>
            {
                { "Authorization", "" }
            },
            InstanceTag = "benchmark-v4"
        };

        _unleash = new UnleashClientFactory().CreateClient(unleashSettings);
        _context = new UnleashContext()
        {
            UserId = "databaseName",
            Properties = new Dictionary<string, string>
            {
                { "constrainKey", "constrainValue" }
            }
        };
    }

    [Benchmark]
    public bool TestIsEnabled()
    {
        return _unleash.IsEnabled(ToggleName, _context);
    }

    [Benchmark]
    public Variant TestGetVariant()
    {
        return _unleash.GetVariant(VariantName, _context, Variant.DISABLED_VARIANT);
    }
}