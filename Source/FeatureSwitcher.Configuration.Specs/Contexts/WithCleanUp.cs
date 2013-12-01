using Machine.Specifications;

namespace FeatureSwitcher.Configuration.Specs.Contexts
{
    public class WithCleanUp
    {
        Cleanup clean = () => Features.Are.HandledByDefault();
    }
}