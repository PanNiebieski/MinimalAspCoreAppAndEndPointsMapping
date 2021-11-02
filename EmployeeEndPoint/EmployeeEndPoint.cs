using EndPointsMappingTool;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeEndPointProject
{
    public class EmployeeEndPoint : IEndpointDefinition
    {
        //public void DefineEndpoints(IEndpointRouteBuilder app)
        public void DefineEndpoints(WebApplication app)
        {
            app.MapPost("/employee",
                (Employee e, IEmployeeService ser) =>
                {
                    return ser.ShowEmployee(e);
                });
        }

        public void DefineServices(IServiceCollection services)
        {
            services.AddSingleton<IEmployeeService, EmployeeService>();
        }
    }
}
