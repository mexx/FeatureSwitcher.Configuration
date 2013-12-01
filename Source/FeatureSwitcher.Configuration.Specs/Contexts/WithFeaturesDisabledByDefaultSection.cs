using Machine.Specifications;

namespace FeatureSwitcher.Configuration.Specs.Contexts
{
    public class WithFeaturesDisabledByDefaultSection : WithApplicationConfiguration
    {
        Establish ctx = () => DefaultSection.FeaturesEnabled = false;
    }
}