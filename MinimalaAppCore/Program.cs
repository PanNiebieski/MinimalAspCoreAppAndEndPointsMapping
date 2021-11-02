using EmployeeEndPointProject;
using EndPointsMappingTool;
using HelloWorldEndPointProject;
using QuoteEndPointProject;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointDefinitions
                        (typeof(EmployeeEndPoint),
                        typeof(HelloWorldEndpoint),
                        typeof(QuoteEndpoint));

var app = builder.Build();

app.MapGet("/", () => "Daj Like");

app.UseEndpointDefinitions();
app.Run();
