﻿namespace AutoMoreira.Persistence.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public RoleService(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;       
        }

        public async Task<RoleDTO> AddRoleAsync(RoleDTO roleDTO)
        {
            try
            {
                Role role = new(roleDTO.Name);

                await _roleRepository.AddAsync(role);

                return _mapper.Map<RoleDTO>(role);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<RoleDTO> UpdateRoleAsync(RoleDTO roleDTO)
        {
            try
            {
                Role role = await _roleRepository.FindByIdAsync(roleDTO.Id);

                if (role == null) throw new Exception("Cargo não encontrado.");

                role.UpdateRole(roleDTO.Name);

                await _roleRepository.UpdateAsync(role);

                return _mapper.Map<RoleDTO>(role);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<RoleDTO>> GetAllRolesAsync()
        {
            try
            {
                List<Role> roles = await _roleRepository
                    .GetAll()
                    .OrderBy(x => x.Id)
                    .ToListAsync();

                return _mapper.Map<List<RoleDTO>>(roles);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<RoleDTO> GetRoleByIdAsync(int roleId)
        {
            try
            {
                Role role = await _roleRepository.FindByIdAsync(roleId);

                if (role == null) throw new Exception("Cargo não encontrado.");

                return _mapper.Map<RoleDTO>(role);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
