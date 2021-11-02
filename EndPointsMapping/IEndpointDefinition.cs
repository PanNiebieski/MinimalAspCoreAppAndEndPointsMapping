using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EndPointsMappingTool
{
    public interface IEndpointDefinition
    {
        void DefineServices(IServiceCollection
            services);

        //void DefineEndpoints(IHost app)
        //void DefineEndpoints(IEndpointRouteBuilder app)
        void DefineEndpoints(WebApplication app);
    }
}