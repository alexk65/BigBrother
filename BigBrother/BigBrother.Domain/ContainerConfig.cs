using BigBrother.Domain.Projects.Services;
using BigBrother.Domain.SubProjects.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BigBrother.Domain
{
    public static class ContainerConfig
    {
        public static IServiceCollection AddDomain(
            this IServiceCollection services)
        {
            services.AddScoped<ISubProjectBuilder, SubProjectBuilder>();
            services.AddScoped<IProjectService, ProjectService>();

            return services;
        }
    }
}
