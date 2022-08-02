using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using GraphQlHandsOn.Interfaces;
using GraphQlHandsOn.Query;
using GraphQlHandsOn.Schema;
using GraphQlHandsOn.Services;
using GraphQlHandsOn.Type;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddSingleton<ProductType>();
builder.Services.AddSingleton<ProductQuery>();
builder.Services.AddSingleton<ISchema, ProductSchema>();
builder.Services.AddGraphQL(options => options.EnableMetrics = false)
    .AddSystemTextJson();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

//app.MapControllers();

app.Run();