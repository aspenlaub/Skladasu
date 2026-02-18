using Autofac;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable UnusedMember.Global

namespace Aspenlaub.Net.GitHub.CSharp.Skladasu.Components;

public static class SkladasuContainerBuilder {
    public static ContainerBuilder UseSkladasu(this ContainerBuilder builder, string applicationName) {
        return builder;
    }

    public static IServiceCollection UseSkladasu(this IServiceCollection services, string applicationName) {
        return services;
    }
}