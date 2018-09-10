using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Entities.DTOs;
using School.Entities.EF6;
using School.NetFramework.DataAccess;

namespace School.NetFramework.Bussiness
{
    public class ProcessInscription
    {

        public IEnumerable<InscriptionDto> GetInscriptions()
        {
            List<InscriptionDto> list = new List<InscriptionDto>();
            using(var access = new SQLDataAccessInscription())
            {
                var saverInscriptions = access.GetInscriptions();
                saverInscriptions.ToList().ForEach(item =>
                {
                    list.Add(MapEntityToDto(item));
                });
            }
            return list;
        }

        public InscriptionDto GetInscription(int StudentId, string SchoolId)
        {
            InscriptionDto inscription = new InscriptionDto();
            using (var access = new SQLDataAccessInscription())
            {
                inscription = MapEntityToDto(access.GetInscription(StudentId, SchoolId));
            }
            return inscription;
        }

        public int InsertInscription(InscriptionDto inscription)
        {
            using(var access = new SQLDataAccessInscription())
            {
                access.InsertInscription(MapDtoToEntity(inscription));
            }
            return inscription.StudentId;
        }

        public void UpdateInscription(InscriptionDto inscription)
        {
            using(var access= new SQLDataAccessInscription())
            {
                access.UpdateInscription(MapDtoToEntity(inscription));
            }
        }

        public void DeleteInscription(InscriptionDto inscription)
        {
            using(var access = new SQLDataAccessInscription())
            {
                access.DeleteInscription(MapDtoToEntity(inscription));
            }
        }

        private Inscription MapDtoToEntity(InscriptionDto inscriptionDto)
        {
            return new Inscription
            {
                StudentId = inscriptionDto.StudentId,
                SchoolId = inscriptionDto.SchoolId,
                InscriptionDate = inscriptionDto.InscriptionDate
            };
        }

        private InscriptionDto MapEntityToDto(Inscription inscription)
        {
            return new InscriptionDto
            {
                StudentId = inscription.StudentId,
                SchoolId = inscription.SchoolId,
                InscriptionDate =inscription.InscriptionDate
            };
        }
    }
}
