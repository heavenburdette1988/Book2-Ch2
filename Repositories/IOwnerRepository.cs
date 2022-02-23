using DogGoMVC2.Models;
using System.Collections.Generic;

namespace DogGoMVC2.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);

        
        Owner GetOwnerByEmail(string email);
        
        void AddOwner(Owner owner);

        void UpdateOwner(Owner owner);
        void DeleteOwner(int ownerId);
    }
}
