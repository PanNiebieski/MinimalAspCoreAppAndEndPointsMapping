using EndPointsMappingTool;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HelloWorldEndPointProject
{
    public class HelloWorldEndpoint : IEndpointDefinition
    {
        //public void DefineEndpoints(IEndpointRouteBuilder app)

        public void DefineEndpoints(WebApplication app)
        {
            app.MapGet("/hello",
                (HttpContext context, IHelloWorldService service)
                =>
                {
                    return service.SayHello
                    (context.Request.Query["name"].ToString());
                });
        }

        public void DefineServices(IServiceCollection services)
        {
            services.AddSingleton<IHelloWorldService, HelloWorldService>();  
        }
    }

}