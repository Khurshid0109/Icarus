using AutoMapper;
using System.Data;
using Icarus.Domain.Entities;
using Icarus.Service.Helpers;
using Icarus.Service.Exceptions;
using Icarus.Service.DTOs.Users;
using Microsoft.EntityFrameworkCore;
using Icarus.Data.IRepositories.Users;
using Icarus.Service.Interfaces.Users;
using Icarus.Service.Helpers.Hasher;
using Icarus.Domain.Configurations;
using Icarus.Service.Commons.Extensions;

namespace Icarus.Service.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<bool> RemoveAsync(long id)
        {
            var user = await _userRepository.SelectAll()
                .Where(u => u.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (user is null)
                throw new IcarusException(404, "User is not found !");

            var imageFullPath = Path.Combine(WebHostEnvironmentHelper.WebRootPath, user.Image);

            if (File.Exists(imageFullPath))
                File.Delete(imageFullPath);

            await _userRepository.DeleteAsync(id);
            await _userRepository.SaveAsync();

            return true;
        }

        public async Task<UserForResultDto> RetrieveByIdAsync(long id)
        {
            var byIdUser = await _userRepository.SelectAll()
                .Where(u => u.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync() ??
                    throw new IcarusException(404, "User is not found! ");

            return _mapper.Map<UserForResultDto>(byIdUser);
        }

        public async Task<IEnumerable<UserForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var allUser = await _userRepository.SelectAll()
                  .AsNoTracking()
                  .ToPagedList<User, long>(@params)
                  .ToListAsync();

            await _userRepository.SaveAsync();

            return _mapper.Map<IEnumerable<UserForResultDto>>(allUser);
        }

        public async Task<UserForResultDto> AddAsync(UserForCreationDto dto)
        {
            var addUser = await _userRepository.SelectAll()
                .Where(u => u.Email.ToLower() == dto.Email.ToLower())
                .FirstOrDefaultAsync();

            if (addUser is not null)
                throw new IcarusException(409, "User alredy exists");

            var image = await MediaHelper.UploadFile(dto.Image);

            var mapped = _mapper.Map<User>(dto);
            mapped.CreatedAt = DateTime.UtcNow;
            mapped.Password = HashPasswordHelper.PasswordHasher(dto.Password);
            mapped.Image = image;

            var result = await _userRepository.InsertAsync(mapped);
            await _userRepository.SaveAsync();

            return _mapper.Map<UserForResultDto>(result);
        }

        public async Task<UserForResultDto> RetrieveByEmailAsync(string email)
        {
            var user = await _userRepository.SelectAll()
                .Where(u => u.Email == email)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (user is null)
                throw new IcarusException(404, "User is not found! ");

            await _userRepository.SaveAsync();

            return _mapper.Map<UserForResultDto>(user);

        }

        public async Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto)
        {
            var user = await _userRepository.SelectAll()
               .Where(u => u.Id == id)
               .AsNoTracking()
               .FirstOrDefaultAsync();

            if(user is null)
                   throw new IcarusException(404, "User is not found");

            var image = await MediaHelper.UploadFile(dto.Image);

            var mappedUser = this._mapper.Map(dto, user);
            mappedUser.UpdatedAt = DateTime.UtcNow;
            mappedUser.Password = HashPasswordHelper.PasswordHasher(dto.Password);
            mappedUser.Image = image;


            await this._userRepository.UpdateAsync(mappedUser);

            await _userRepository.SaveAsync();

            return this._mapper.Map<UserForResultDto>(mappedUser);
        }

        public async Task<UserForResultDto> RetrieveByPhoneNumber(string phoneNumber)
        {
            var user = await _userRepository.SelectAll()
                 .Where(u => u.Phone.Trim() == phoneNumber.Trim())
                 .AsNoTracking()
                 .FirstOrDefaultAsync();

            if (user is null)
                throw new IcarusException(404, "User is not found!");

            return _mapper.Map<UserForResultDto>(user);
        }

        
    }
}
