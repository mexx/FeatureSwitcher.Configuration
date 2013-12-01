using FeatureSwitcher.Configuration.Specs.Behaviors;
using FeatureSwitcher.Configuration.Specs.Contexts;
using FeatureSwitcher.Configuration.Specs.Domain;
using Machine.Specifications;

namespace FeatureSwitcher.Configuration.Specs
{
    public class When_features_are_disabled_by_default_section_and_simple_feature_explicitly_enabled_by_features_section : WithFeaturesDisabledByDefaultSection
    {
        Establish ctx = () => FeaturesSection.Features.Add(new FeatureElement { Name = typeof(Simple).FullName, Enabled = true });

        Behaves_like<Disabled<Basic>> a_disabled_basic_feature;

        Behaves_like<Enabled<Simple>> an_enabled_simple_feature;

        Behaves_like<Disabled<Complex>> a_disabled_complex_feature;
    }
}