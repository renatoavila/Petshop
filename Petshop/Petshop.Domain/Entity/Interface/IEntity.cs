using System;

namespace Petshop.Domain.Entity.Interfaces
{
    public interface IEntity 
    {
        long Id { get; set; }
        Guid Key { get; set; }
    }
}
