using AliceRestaurant;
using AliceRestaurant.Data;
using AliceRestaurant.Extensions;
using AliceRestaurant.MapperConfig;
using AliceRestaurant.DataAccess.Repository;
using AliceRestaurant.DataAccess.Repository.IRepository;
using AliceRestaurant.Service;
using AliceRestaurant.Service.IService;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using AliceRestaurant.DataAccess.UnitOfWork.IUnitOfWork;
using AliceRestaurant.DataAccess.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlServerOptionsAction: sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5,  // Maximum number of retry attempts.
                maxRetryDelay: TimeSpan.FromSeconds(15),  // Maximum delay between retries.
                errorNumbersToAdd: null);  // SQL error codes to consider as transient.
        });
});

// add DI
builder.Services.AddScoped<IDishRepository, DishRepository>();
builder.Services.AddScoped<IChangeLogRepository, ChangeLogRepository>();
builder.Services.AddScoped<IDineInCategoryRepository, DineInCategoryRepository>();
builder.Services.AddScoped<IDeliveryCategoryRepository, DeliveryCategoryRepository>();
builder.Services.AddScoped<IRestaurantRepository, RestaurantRepository>();
builder.Services.AddScoped<IDropdownRepository, DropdownRepository>();
builder.Services.AddScoped<IRestaurantDishRepository, RestaurantDishRepository>();

// add unit of work
builder.Services.AddScoped<IUnitofWork, UnitofWork>();

// add services
builder.Services.AddScoped(typeof(IChangeLogService<>), typeof(ChangeLogService<>));
builder.Services.AddScoped<IChangeLogServiceFactory, ChangeLogServiceFactory>();



// explicit control over the creation and registration of the IMapper instance
IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// add authentication with JWT
builder.AddAppAuthentication();

builder.Services.AddControllers(options =>
{
    options.Conventions.Add(new RouteTokenTransformerConvention(
                                new LowercaseControllerParameterTransformer()));
});

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
// if (app.Environment.IsDevelopment())
// {
app.UseSwagger();
app.UseSwaggerUI();
// }

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.UseCors("CorsPolicy");

// create a custom service extension to upadate the db if migrations is exsiting
app.DBMigration();

app.Run();
