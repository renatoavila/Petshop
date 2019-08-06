using Petshop.Domain.Entity;
using Petshop.Repository.Base;
using Petshop.Repository.Interface;
using Microsoft.Extensions.Configuration;

namespace Petshop.Repository
{
    public class PetRepository : Repository<Pet>, IPetRepository
    {
        public PetRepository(IConfiguration config) : base(config)
        {
        }
         
    }
}
