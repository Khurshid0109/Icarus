using AutoMapper;
using Icarus.Domain.Entities;
using Icarus.Service.DTOs.Users;
using Icarus.Service.DTOs.Assets;
using Icarus.Service.DTOs.Categories;
using Icarus.Service.DTOs.Departments;
using Icarus.Service.DTOs.DepartmentCategories;
using Icarus.Service.DTOs.DepartmentResponses;
using Icarus.Service.DTOs.Requests;
using Icarus.Service.DTOs.Auth;
using Icarus.Service.DTOs.BotUser;

namespace Icarus.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Asset
        CreateMap<Asset,AssetForResultDto>().ReverseMap();
        CreateMap<Asset,AssetForUpdateDto>().ReverseMap();
        CreateMap<Asset,AssetForCreationDto>().ReverseMap();

        // Category
        CreateMap<Category,CategoryForResultDto>().ReverseMap();
        CreateMap<Category,CategoryForUpdateDto>().ReverseMap();
        CreateMap<Category,CategoryForCreationDto>().ReverseMap();

        // Department
        CreateMap<Department,DepartmentForCreationDto>().ReverseMap();
        CreateMap<Department, DepartmentForResultDto>().ReverseMap();
        CreateMap<Department,DepartmentForUpdateDto>().ReverseMap();

        // DepartmentCategory
        CreateMap<DepartmentCategory,DepartmentCategoryForUpdateDto>().ReverseMap();
        CreateMap<DepartmentCategory, DepartmentCategoryForResultDto>().ReverseMap();
        CreateMap<DepartmentCategory, DepartmentCategoryForCreationDto>().ReverseMap();

        // DepartmentResponse
        CreateMap<DepartmentResponse,DResponseForResultDto>().ReverseMap();
        CreateMap<DepartmentResponse,DResponseForUpdateDto>().ReverseMap();
        CreateMap<DepartmentResponse,DResponseForCreationDto>().ReverseMap();

        // User
        CreateMap<User, UserForCreationDto>().ReverseMap();
        CreateMap<User, UserForUpdateDto>().ReverseMap();
        CreateMap<User, UserForResultDto>().ReverseMap();

        // Request
        CreateMap<Request, RequestForCreationDto>().ReverseMap();
        CreateMap<Request, RequestForResultDto>().ReverseMap();
        CreateMap<Request, RequestForUpdateDto>().ReverseMap();

        // BotUser
        CreateMap<BotUser,BotUserForCreationDto>().ReverseMap();
        CreateMap<BotUser,BotUserForResultDto>().ReverseMap();
        CreateMap<BotUser,BotUserForUpdateDto>().ReverseMap();

        CreateMap<User, RegisterDto>().ReverseMap();
    }
}
