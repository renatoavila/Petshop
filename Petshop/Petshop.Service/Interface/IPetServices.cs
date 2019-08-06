using Petshop.Domain.Entity;
using System;
using System.Collections.Generic;

namespace PetShop.Service.Interface
{
    public interface IPetServices
    {
        Pet Get(Guid key);
        Guid Insert(Pet pet);
        Guid Update(Pet pet);
        void Delete(Guid key);
        List<Pet> GetAll();
    }
}