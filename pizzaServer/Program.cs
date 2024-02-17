using bigPizzaServer.Interface;
using bigPizzaServer.pizzaServer.middlewares;
using bigPizzaServer.service;
using FileService;
using bigPizzaServer.pizzaServer.extensions;
using bigPizzaServer.models.models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IPizza, PizzaService>();
builder.Services.AddScoped<IWorker, WorkerService>();
builder.Services.AddTransient<IOrder, OrderService>();
builder.Services.AddSingleton<IFile<Pizza>,ReadWrite<Pizza>>();
//builder.Services.AddSingleton<IOrder, OrderService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseDefaultFiles();
app.UseStaticFiles();



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<LogMiddleware>();

app.Run();
