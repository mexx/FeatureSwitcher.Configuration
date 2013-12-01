using FeatureSwitcher.Configuration.Specs.Behaviors;
using FeatureSwitcher.Configuration.Specs.Contexts;
using FeatureSwitcher.Configuration.Specs.Domain;
using Machine.Specifications;

namespace FeatureSwitcher.Configuration.Specs
{
    public class When_features_are_enabled_by_default_section_and_simple_feature_explicitly_disabled_by_features_section : WithFeaturesEnabledByDefaultSection
    {
        Establish ctx = () => FeaturesSection.Features.Add(new FeatureElement { Name = typeof(Simple).FullName, Enabled = false });

        Behaves_like<Enabled<Basic>> an_enabled_basic_feature;

        Behaves_like<Disabled<Simple>> a_disabled_simple_feature;

        Behaves_like<Enabled<Complex>> an_enabled_complex_feature;
    }
}