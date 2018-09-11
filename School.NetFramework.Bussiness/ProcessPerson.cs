using AutoMapper;
using School.Entities.DTOs;
using School.Entities.EF6;
using School.NetFramework.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.NetFramework.Bussiness
{
    public class ProcessPerson
    {
        private IMapper mapper;

        public ProcessPerson()
        {
            mapper = new AutoMapperConfig().CreateMapperConfiguration();
        }

        public PersonDto GetPerson(int id)
        {
            PersonDto savedPersonDto = new PersonDto();
            using (var dataAccess = new SQLDataAccessPerson())
            {
                var savedPerson = dataAccess.GetPerson(id);

                savedPersonDto = this.mapper.Map<PersonDto>(savedPerson);
            }
            return savedPersonDto;
        }

        public IEnumerable<PersonDto> GetPersons()
        {
            List<PersonDto> savedPersonsDto = new List<PersonDto>();
            using (var dataAccess = new SQLDataAccessPerson())
            {
                var savedPersons = dataAccess.GetPersons();

                foreach (var item in savedPersons)
                {
                    savedPersonsDto.Add(MapEntityToDto(item));
                }

                savedPersons.ToList().ForEach(item =>
                {
                    savedPersonsDto.Add(MapEntityToDto(item));
                });

                savedPersonsDto = this.mapper.Map<List<PersonDto>>(savedPersons);
            }
            return savedPersonsDto;
        }


        public int InsertNewPerson(PersonDto personDto)
        {
            int newPersonId = 0;
            using (var dataAccess = new SQLDataAccessPerson())
            {
                Person newPerson = this.mapper.Map<Person>(personDto);
                newPersonId = dataAccess.InsertPerson(newPerson);
            }
            return newPersonId;
        }

        public void UpdatePerson(PersonDto personDto)
        {
            using (var dataAccess = new SQLDataAccessPerson())
            {
                Person newPerson = this.mapper.Map<Person>(personDto);
                dataAccess.UpdatePerson(newPerson);
            }
        }

        public void DeletePerson(PersonDto personDto)
        {
            using (var dataAccess = new SQLDataAccessPerson())
            {

                Person newPerson = this.MapDtoToEntity(personDto);
                dataAccess.DeletePerson(newPerson.PersonId);
            }
        }


        private Person MapDtoToEntity(PersonDto personDto)
        {
            return new Person
            {
                
                PersonId = personDto.PersonId,
                PersonName = personDto.PersonFirstName,
                PersonAge = personDto.PersonAge,
                AddressId = personDto.AddressId,
                CURP = personDto.CURP,
                Phone = personDto.Phone,
                Email = personDto.Email,
                RolId = personDto.RolId,

            };
        }


        private PersonDto MapEntityToDto(Person person)
        {
            return new PersonDto
            {
                PersonId = person.PersonId,
                PersonFirstName = person.PersonName,
                PersonAge = person.PersonAge,
                AddressId = person.AddressId,
                CURP = person.CURP,
                Phone= person.Phone,
                Email= person.Email,
                RolId= person.RolId,
            };
        }


    }
}
