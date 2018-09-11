using School.Entities.EF6;
using School.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.NetFramework.DataAccess;

namespace School.NetFramework.Bussiness
{
    public class ProcessSchoolUser
    {

        public ProcessSchoolUser()
        {

        }

        public int InsertNewUser(SchoolUserDto userDto)
        {
            int newUserId = 0;
            using (var dataAccess = new SQLDataAccessSchoolUser())
            {
                SchoolUser newUser = this.MapDtoToEntity(userDto);
               
                newUserId = dataAccess.InsertUser(newUser);
            }
            return newUserId;
        }



        public void UpdateUser(SchoolUserDto userDto)
        {
            using (var dataAccess = new SQLDataAccessSchoolUser())
            {

                SchoolUser newUser = this.MapDtoToEntity(userDto);
                


                dataAccess.UpdateUser(newUser);
            }
        }


        public void DeleteUser(SchoolUserDto userDto)
        {
            using (var dataAccess = new SQLDataAccessSchoolUser())
            {

                SchoolUser newUser = this.MapDtoToEntity(userDto);
                dataAccess.DeleteUser(newUser.SchoolUserId);
            }
        }



        public IEnumerable<SchoolUserDto> GetUsers()
        {
            List<SchoolUserDto> savedUsersDto = new List<SchoolUserDto>();
            using (var dataAccess = new SQLDataAccessSchoolUser())
            {
                var savedUsers = dataAccess.GetUsers();

                foreach (var item in savedUsers)
                {
                    savedUsersDto.Add(MapEntityToDto(item));
                }

                //savedUsers.ToList().ForEach(item =>
                //{
                //    savedUsersDto.Add(MapEntityToDto(item));
                //});

               
            }
            return savedUsersDto;
        }


        public SchoolUserDto GetUser(int id)
        {
            SchoolUserDto savedUserDto = new SchoolUserDto();
            using (var dataAccess = new SQLDataAccessSchoolUser())
            {
                var savedUsers = dataAccess.GetUser(id);

                savedUserDto = MapEntityToDto(savedUsers);
                    
            }
            return savedUserDto;
        }

        private SchoolUser MapDtoToEntity(SchoolUserDto userDto)
        {
            return new SchoolUser
            {
                SchoolUserId = userDto.SchoolUserId,
                UserName = userDto.UserName,
                Password = userDto.Password,
                RolId = userDto.RolId,
                IsActive = userDto.IsActive
            };
        }

        private SchoolUserDto MapEntityToDto(SchoolUser user)
        {
            return new SchoolUserDto
            {
                SchoolUserId = user.SchoolUserId,
                UserName = user.UserName,
                Password = user.Password,
                RolId = user.RolId,
                IsActive = user.IsActive
            };
        }
    }
}
