using FeatureSwitcher.Configuration.Specs.Behaviors;
using FeatureSwitcher.Configuration.Specs.Contexts;
using FeatureSwitcher.Configuration.Specs.Domain;
using Machine.Specifications;

namespace FeatureSwitcher.Configuration.Specs
{
    public class When_features_are_enabled_by_default_section : WithFeaturesEnabledByDefaultSection
    {
        Behaves_like<Enabled<Basic>> an_enabled_basic_feature;

        Behaves_like<Enabled<Simple>> an_enabled_simple_feature;

        Behaves_like<Enabled<Complex>> an_enabled_complex_feature;
    }
}