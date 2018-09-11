using AutoMapper;
using School.Entities.DTOs;
using School.Entities.EF6;
using School.NetFramework.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace School.NetFramework.Bussiness
{
    public class ProcessCatalogs
    {
        private IMapper mapper;

        public ProcessCatalogs()
        {
            mapper = new AutoMapperConfig().CreateMapperConfiguration();
        }

        public int InsertNewRole(RolDto rolDto)
        {
            int newRolId = 0;
            using (var dataAccess = new SQLDataAccess())
            {
                Roles newRol = this.mapper.Map<Roles>(rolDto);
                newRolId = dataAccess.InsertRol(newRol);
            }
            return newRolId;
        }

        public RolDto GetRol(int rolId)
        {
            RolDto rol = new RolDto();
            using (var dataAccess = new SQLDataAccess())
            {
                var savedRol = dataAccess.GetRol(rolId);
                rol = this.mapper.Map<RolDto>(savedRol);
            }
            return rol;
        }

        public void UpdateRol(int rolId, RolDto rolDto)
        {
            using (var dataAccess = new SQLDataAccess())
            {
                Roles newRol = this.MapDtoToEntity(rolDto);
                newRol.RolId = rolId;
                dataAccess.UpdateRol(newRol);
            }
        }

        public IEnumerable<RolDto> GetRoles()
        {
            List<RolDto> savedRolesDto = new List<RolDto>();
            using (var dataAccess = new SQLDataAccess())
            {
                var savedRoles = dataAccess.GetRoles();

                foreach (var item in savedRoles)
                {
                    savedRolesDto.Add(MapEntityToDto(item));
                }

                savedRoles.ToList().ForEach(item =>
                {
                    savedRolesDto.Add(MapEntityToDto(item));
                });

                savedRolesDto = this.mapper.Map<List<RolDto>>(savedRoles);
            }
            return savedRolesDto;
        }

        public void DeleteRol(int rolId)
        {
            using (var dataAccess = new SQLDataAccess())
            {
                dataAccess.DeleteRol(rolId);
            }
        }

        private Roles MapDtoToEntity(RolDto rolDto)
        {
            return new Roles
            {
                RolId = rolDto.Id,
                RolName = rolDto.Name,
                IsActive = rolDto.IsActive
            };
        }

        private RolDto MapEntityToDto(Roles rol)
        {
            return new RolDto
            {
                Id = rol.RolId,
                Name = rol.RolName,
                IsActive = rol.IsActive
            };
        }
    }
}