using DogGoMVC2.Models;
using System.Collections.Generic;

namespace DogGoMVC2.Repositories
{
    public interface IWalkRepository
    {
        List<Walk> GetAllWalks();
        List<Walk> GetWalksByWalkerId(int walkId);
    }
}
