using Services;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IInterest, SimpleInt>();
//builder.Services.AddSingleton<IInterest, CompoundInt>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
