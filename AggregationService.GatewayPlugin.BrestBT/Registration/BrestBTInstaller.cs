using System.ComponentModel;
using AggregationService.GatewayPlugin.BrestBT.HttpClient;

namespace AggregationService.GatewayPlugin.BrestBT.Registration
{
    public class BrestBTInstaller : IWindsorInstaller
    {
        void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IBrestBTClient>()
                    .ImplementedBy<BrestBTClient>()
                    .LifestyleSingleton(),

                Component.For<IHttpClientFactory>()
                    .ImplementedBy<HttpClientFactory>()
                    .LifestyleTransient());

                Component.For<IHttpClient>()
                .ImplementedBy<RestSharpHttpClient>()
                .LifestyleTransient());
        }
    }
}
