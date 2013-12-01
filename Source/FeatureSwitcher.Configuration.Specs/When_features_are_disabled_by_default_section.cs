using FeatureSwitcher.Configuration.Specs.Behaviors;
using FeatureSwitcher.Configuration.Specs.Contexts;
using FeatureSwitcher.Configuration.Specs.Domain;
using Machine.Specifications;

namespace FeatureSwitcher.Configuration.Specs
{
    public class When_features_are_disabled_by_default_section : WithFeaturesDisabledByDefaultSection
    {
        Behaves_like<Disabled<Basic>> a_disabled_basic_feature;

        Behaves_like<Disabled<Simple>> a_disabled_simple_feature;

        Behaves_like<Disabled<Complex>> a_disabled_complex_feature;
    }
}