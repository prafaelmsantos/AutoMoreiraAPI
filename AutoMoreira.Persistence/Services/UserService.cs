﻿namespace AutoMoreira.Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper, IUserRepository userRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<SignInResult> CheckUserPasswordAsync(UserDTO userDTO, string password)
        {
            try
            {
                User user = await _userManager.Users.SingleOrDefaultAsync(user => user.UserName == userDTO.UserName.ToLower());

                return await _signInManager.CheckPasswordSignInAsync(user, password, false);

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao tentar verificar password. Erro: {ex.Message}");

            }
        }

        public async Task<UserDTO> CreateUserAsync(UserDTO userDTO)
        {
            try
            {
                User user = new(userDTO.UserName, userDTO.Email, userDTO.PhoneNumber, userDTO.FirstName, userDTO.LastName, userDTO.Image, userDTO.DarkMode);

                IdentityResult identityResult = await _userManager.CreateAsync(user, userDTO.Password);

                if (identityResult.Succeeded)
                {
                    return _mapper.Map<UserDTO>(user);
                }
                return null;

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao tentar criar conta de utilizador!. Erro: {ex.Message}");

            }
        }

        public async Task<UserDTO> GetUserByUserNameAsync(string userName)
        {
            try
            {
                User user = await _userRepository.FindByCondition(x=> x.UserName == userName).FirstOrDefaultAsync();
                
                if (user == null) throw new Exception("Utilizador não encontrado.");

                return _mapper.Map<UserDTO>(user);

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao tentar procurar utilizador por Username. Erro: {ex.Message}");

            }
        }

        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            try
            {
                User user = await _userRepository.FindByIdAsync(id);
                
                if (user == null) throw new Exception("Utilizador não encontrado.");

                return _mapper.Map<UserDTO>(user);

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao tentar procurar utilizador por Username. Erro: {ex.Message}");
            }
        }
        public async Task<List<UserDTO>> GetAllUsersAsync()
        {
            try
            {
                List<User> users = await _userRepository.GetAll().OrderBy(x => x.Id).ToListAsync();

                return _mapper.Map<List<UserDTO>>(users);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<UserDTO> UpdateUserAsync(UserDTO userDTO)
        {
            try
            {
                User user = await _userRepository.FindByIdAsync(userDTO.Id);

                if (user == null) throw new Exception("Utilizador não encontrado.");

                user.UpdateUser(userDTO.UserName, userDTO.Email, userDTO.PhoneNumber, userDTO.FirstName, userDTO.LastName, userDTO.Image, userDTO.DarkMode);

                if (userDTO.Password != null)
                {
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                    await _userManager.ResetPasswordAsync(user, token, userDTO.Password);
                }
                
                await _userRepository.UpdateAsync(user);

                return _mapper.Map<UserDTO>(user);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao tentar atualizar utilizador. Erro: {ex.Message}");
            }
        }

        public async Task<UserDTO> UpdateUserModeAsync(UserUpdateModeDTO userUpdateModeDTO)
        {
            try
            {
                User user = await _userRepository.FindByIdAsync(userUpdateModeDTO.Id);

                if (user == null) throw new Exception("Utilizador não encontrado.");

                user.SetDarkMode(userUpdateModeDTO.DarkMode);

                await _userRepository.UpdateAsync(user);

                return _mapper.Map<UserDTO>(user);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao tentar atualizar o modo de utilizador. Erro: {ex.Message}");
            }
        }

        public async Task<bool> UserExists(string userName)
        {
            try
            {
                return await _userManager.Users.AnyAsync(user => user.UserName == userName.ToLower());

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao tentar verificar se o utilizador existe. Erro: {ex.Message}");

            }
        }
    }
}
