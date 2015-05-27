using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using SimpleTaskSystem.Pets.Dtos;

namespace SimpleTaskSystem.Pets
{
    public interface IPetAppService : IApplicationService
    {
        GetAllPetsOutput GetAllPets();
    }


    public class PetAppService : IPetAppService
    {
        private IRepository<Pet> _petRepository;

        public PetAppService(IRepository<Pet> petRepository)
        {
            this._petRepository = petRepository;
        }

        public GetAllPetsOutput GetAllPets()
        {
            var pets = this._petRepository.GetAll();

            return new GetAllPetsOutput()
            {
                Pets = Mapper.Map<List<PetDto>>(pets)
            };
        }
    }
}


