
using Serilog;
using Newtonsoft.Json;
using Icarus.Api.Models;
using Icarus.Api.Extensions;
using Icarus.Api.Middlewares;
using Icarus.Data.DbContexts;
using Icarus.Service.Helpers;
using Icarus.Service.Mappers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Icarus.Service.Commons.Helpers;




var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<IcarusDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Fix the Cycle
//builder.Services.AddControllers()
//     .AddNewtonsoftJson(options =>
//     {
//         options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
//     });

builder.Services.AddControllers();
builder.Services.AddCustomService();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

// Serialog
var logger = new LoggerConfiguration()
   .ReadFrom.Configuration(builder.Configuration)
   .Enrich.FromLogContext()
   .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

builder.Services.AddSwaggerService();
builder.Services.AddHttpContextAccessor();

builder.Services.AddMemoryCache();
builder.Services.AddJwtService(builder.Configuration);

builder.Services.AddAutoMapper(typeof(MappingProfile));

// Configure api url name
builder.Services.AddControllers(options =>
{
    options.Conventions.Add(new RouteTokenTransformerConvention(
                                        new ConfigurationApiUrlName()));
});

var app = builder.Build();
WebHostEnvironmentHelper.WebRootPath = Path.GetFullPath("wwwroot");

if (app.Services.GetService<IHttpContextAccessor>() != null)
    HttpContextHelper.Accessor = app.Services.GetRequiredService<IHttpContextAccessor>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseMiddleware<ExceptionHandlerMiddleWare>();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();
app.UseCors("AAA");

app.MapControllers();

app.Run();

