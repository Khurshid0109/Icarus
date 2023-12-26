using Icarus.Data.Repositories;
using Icarus.Data.IRepositories;
using Icarus.Service.Services.Users;
using Icarus.Service.Services.Assets;
using Icarus.Data.Repositories.Users;
using Icarus.Data.Repositories.Assets;
using Icarus.Service.Interfaces.Users;
using Icarus.Data.IRepositories.Users;
using Icarus.Service.Interfaces.Assets;
using Icarus.Data.IRepositories.Assets;
using Icarus.Service.Services.Categories;
using Icarus.Service.Interfaces.Categories;
using Icarus.Service.Services.DepartmentCategories;
using Icarus.Service.Interfaces.DepartmentCategories;
using Icarus.Service.Interfaces.Departments;
using Icarus.Service.Services.Departments;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Icarus.Data.Repositories.Departments;
using Icarus.Service.Interfaces.DepartmentResponses;
using Icarus.Service.Services.DepartmentResponses;
using Icarus.Service.Services.Requests;
using Icarus.Service.Interfaces.Requests;
using Microsoft.OpenApi.Models;
using System.Reflection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Icarus.Service.Interfaces.Auth;
using Icarus.Service.Services.Auth;



namespace Icarus.Api.Extensions;

public static class ServiceExtension
{
    public static void AddCustomService(this IServiceCollection services)
    {
        // Repository
        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

        // Asset
        services.AddScoped<IAssetService,AssetService>();
        services.AddScoped<IAssetRepository, AssetRepository>();


        // Department
        services.AddScoped<IDepartmentService, DepartmentService>();
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();

        // DepartmentCategory
        services.AddScoped<IDepartmentCategoryService, DepartmentCategoryService>();
        services.AddScoped<IDepartmentCategoryRepository, DepartmentCategoryRepository>();

        // DepartmentResponse
        services.AddScoped<IDepartmentResponseService, DepartmentResponseService>();
        services.AddScoped<IDepartmentResponseReposiroty, DepartmentResponseRepository>();

        // Users
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IUserRepository, UserRepository>();

        //BotUser
        services.AddScoped<IBotUserRepository,BotUserRepository>();
        services.AddScoped<IBotUserService,BotUserService>();

        // Category
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<ICategoryRepository,CategoryRepository>();

        // Request
        services.AddScoped<IRequestService, RequestService>(); 
        services.AddScoped<IRequestRepository, RequestRepository>();

        // Authentication
        services.AddScoped<IAuthService, AuthService>();
    }

    public static void AddJwtService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = configuration["Jwt:Issuer"],
                ValidAudience = configuration["JWT:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
                ClockSkew = TimeSpan.Zero
            };
        });
    }

    public static void AddSwaggerService(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "TestHouse.Api", Version = "v1" });
            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Description =
                    "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey
            });

            c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
          {
              new OpenApiSecurityScheme
              {
                  Reference = new OpenApiReference
                  {
                      Type = ReferenceType.SecurityScheme,
                      Id = "Bearer"
                  }
              },
              new string[]{ }
          }
            });
        });
    }
}