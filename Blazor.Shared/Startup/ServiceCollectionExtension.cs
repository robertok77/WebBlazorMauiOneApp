using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using Blazor.Shared.Contract;
using Refit;

namespace Blazor.Shared.Startup;

public static class ServiceCollectionExtension
{
    public static void AddShared(this IServiceCollection services)
    {
        services.AddRefitClient<IQuotesApi>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:7259"));
    }
}