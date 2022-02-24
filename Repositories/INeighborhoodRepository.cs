using DogGoMVC2.Models;
using System.Collections.Generic;

namespace DogGoMVC2.Repositories
{
    public interface INeighborhoodRepository
    {
         List<Neighborhood> GetAll();
        //List<Neighborhood> GetOwnerById(int id);
    }
}
