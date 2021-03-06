using DogGoMVC2.Models;
using System.Collections.Generic;

namespace DogGoMVC2.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
    }
}
