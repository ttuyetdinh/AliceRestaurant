using AliceRestaurant;
using AliceRestaurant.Data;
using AliceRestaurant.Extensions;
using AliceRestaurant.Repository;
using AliceRestaurant.Repository.IRepository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// add DI
builder.Services.AddScoped<IDishRepository, DishRepository>();
builder.Services.AddScoped<IDineInMenuRepository, DineInMenuRepository>();
builder.Services.AddScoped<IDeliveryMenuRepository, DeliveryMenuRepository>();
builder.Services.AddScoped<IRestaurantRepository, RestaurantRepository>();



// explicit control over the creation and registration of the IMapper instance
IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// add authentication with JWT
builder.AddAppAuthentication();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// add configuration for swagger
builder.Services.AddSingleton<IConfigureOptions<SwaggerGenOptions>, ConfigurationSwaggerGenOptions>();
builder.Services.AddSwaggerGen();

// add CORS configuration
builder.Services.AddCors(option =>
{
    option.AddPolicy("CorsPolicy", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.UseCors("CorsPolicy");

// create a custom service extension to upadate the db if migrations is exsiting
app.DBMigration();

app.Run();
