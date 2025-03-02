using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using University.Models.Dtos;
using University.Models.Dtos.Identity;
using University.Models.Entities;
using University.Repository.Data;
using University.Service.Exceptions;
using University.Service.Interfaces;

namespace University.Service.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IMapper _mapper;

        private const string _adminRole = "Admin";
        private const string _customerRole = "Customer";


        public AuthService
            (ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IJwtTokenGenerator jwtTokenGenerator,
            IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            var user = await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.UserName.ToLower() == loginRequestDto.UserName.ToLower());

            if (user is not null)
            {
                var isValid = await _userManager.CheckPasswordAsync(user, loginRequestDto.Password);

                if (!isValid)
                {
                    return new LoginResponseDto() { Token = string.Empty };
                }

                var roles = await _userManager.GetRolesAsync(user);
                var token = _jwtTokenGenerator.GenerateToken(user, roles);

                LoginResponseDto result = new()
                {
                    Token = token
                };

                if (result is null)
                {
                    throw new InvalidOperationException(loginRequestDto.UserName);
                }

                return result;
            }
            else
            {
                throw new NotFoundException($"User {loginRequestDto.UserName} not found");
            }
        }

        public async Task Register(RegistrationRequestDto registrationRequestDto)
        {
            var user = _mapper.Map<ApplicationUser>(registrationRequestDto);

            var result = await _userManager.CreateAsync(user, registrationRequestDto.Password);

            if (result.Succeeded)
            {
                var userToReturn = await _context.ApplicationUsers.FirstAsync(x => x.Email.ToLower() == registrationRequestDto.Email.ToLower());

                if (userToReturn != null)
                {
                    if (!await _roleManager.RoleExistsAsync(_customerRole))
                        await _roleManager.CreateAsync(new IdentityRole(_customerRole));

                    await _userManager.AddToRoleAsync(userToReturn, _customerRole);
                }
            }
            else
            {
                throw new InvalidOperationException(result.Errors.FirstOrDefault().Description);
            }
        }
        public async Task RegisterAdmin(RegistrationRequestDto registrationRequestDto)
        {
            var user = _mapper.Map<ApplicationUser>(registrationRequestDto);

            var result = await _userManager.CreateAsync(user, registrationRequestDto.Password);

            if (result.Succeeded)
            {
                var userToReturn = await _context.ApplicationUsers.FirstAsync(x => x.Email.ToLower() == registrationRequestDto.Email.ToLower());

                if (userToReturn != null)
                {
                    if (!await _roleManager.RoleExistsAsync(_adminRole))
                        await _roleManager.CreateAsync(new IdentityRole(_adminRole));

                    await _userManager.AddToRoleAsync(userToReturn, _adminRole);
                }
            }
            else
            {
                throw new InvalidOperationException(result.Errors.FirstOrDefault().Description);
            }
        }
    }
}
