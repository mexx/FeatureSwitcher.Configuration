using Machine.Specifications;

namespace FeatureSwitcher.Configuration.Specs.Contexts
{
    public class WithFeaturesEnabledByDefaultSection : WithApplicationConfiguration
    {
        Establish ctx = () => DefaultSection.FeaturesEnabled = true;
    }
}