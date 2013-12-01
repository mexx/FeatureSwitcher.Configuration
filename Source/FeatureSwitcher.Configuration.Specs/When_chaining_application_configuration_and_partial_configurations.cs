using FeatureSwitcher.Configuration.Specs.Behaviors;
using FeatureSwitcher.Configuration.Specs.Contexts;
using FeatureSwitcher.Configuration.Specs.Domain;
using Machine.Specifications;

namespace FeatureSwitcher.Configuration.Specs
{
    public class When_chaining_application_configuration_and_partial_configurations : WithCleanUp
    {
        Establish ctx = () =>
            {
                var appConfig = new AppConfig(true);
                Features.Are
                        .ConfiguredBy.Custom(
                            appConfig.Features,
                            Features.OfType<Simple>.Enabled,
                            appConfig.Default);
            };

        Behaves_like<Disabled<Basic>> a_disabled_basic_feature;

        Behaves_like<Enabled<Simple>> an_enabled_feature_simple;

        Behaves_like<Disabled<Complex>> a_disabled_complex_feature;
    }
}