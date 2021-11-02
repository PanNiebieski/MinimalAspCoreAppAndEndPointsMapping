using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IEmployeeService, EmployeeService>();
builder.Services.AddSingleton<IHelloWorldService, HelloWorldService>();

var app = builder.Build();

app.MapGet("/", () => "Daj Like");

app.MapGet("/quote/", async () =>
    await new HttpClient().GetStringAsync
        ("https://ron-swanson-quotes.herokuapp.com/v2/quotes"));

app.MapPost("/employee",
    (Employee e, IEmployeeService ser) =>
    {
        return ser.ShowEmployee(e);
    });

app.MapGet("/hello",
    (HttpContext context, IHelloWorldService service)
    =>
    {
        return service.SayHello
                    (context.Request.Query["name"].ToString());
    });

app.Run();




public class HelloWorldService : IHelloWorldService
{
    public string SayHello(string user)
    {
        return $"Hello {user}";
    }
}

public interface IHelloWorldService
{
    public string SayHello(string user);
}



public record Employee(string FirstName, [Required] string LastName);

public interface IEmployeeService
{
    public string ShowEmployee(Employee employee);
}

public class EmployeeService : IEmployeeService
{
    public string ShowEmployee(Employee e)
    {
        return "We have a new employee:" +
            $" {e.FirstName}  {e.LastName}";
    }
}



