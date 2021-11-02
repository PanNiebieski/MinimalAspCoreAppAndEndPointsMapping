using EndPointsMappingTool;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace QuoteEndPointProject
{
    public class QuoteEndpoint : IEndpointDefinition
    {
        //public void DefineEndpoints(IEndpointRouteBuilder app)

        public void DefineEndpoints(WebApplication app)
        {
            app.MapGet("/quote/", async () =>
            await new HttpClient().GetStringAsync
            ("https://ron-swanson-quotes.herokuapp.com/v2/quotes"));
        }

        public void DefineServices(IServiceCollection services)
        { }
    }
}