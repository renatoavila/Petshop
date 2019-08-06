using PetShop.Service.Interface;
using Petshop.Domain.Entity;
using Petshop.Repository.Interface;

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace PetShop.Service
{
    public class PetServices : IPetServices
    {
        private readonly IPetRepository _petRepository;


        public PetServices(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public void Delete(Guid key)
        {
            _petRepository.Delete(new Pet() { Key = key });
        }

        public Pet Get(Guid key)
        {
            return _petRepository.Get(key);
        }

        public List<Pet> GetAll()
        {
            return _petRepository.GetAll().ToList();
        }

        public Guid Insert(Pet pet)
        {
            _petRepository.Insert(pet);
            return pet.Key;
        }

        public Guid Update(Pet pet)
        {
            _petRepository.Update(pet);
            return pet.Key;
        }
    }
}
