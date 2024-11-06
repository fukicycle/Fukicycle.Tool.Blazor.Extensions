using Fukicycle.Tool.Blazor.Extensions.Containers;
using Fukicycle.Tool.Blazor.Extensions.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fukicycle.Tool.Blazor.Extensions
{
    public static class AddServiceExtension
    {
        public static IServiceCollection AddBlazorExtensions(this IServiceCollection services)
        {
            services.AddScoped<DialogContainer>();
            services.AddScoped<IDialogService, DialogService>();
            return services;
        }
    }
}
