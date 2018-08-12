namespace Ocelot.Authentication.IdentityServer
{
    using DependencyInjection;

    public static class OcelotBuilderExtensions
    {
        public static IOcelotBuilder AddSomething(this IOcelotBuilder builder)
        {
            return builder;
        }
    }
}
