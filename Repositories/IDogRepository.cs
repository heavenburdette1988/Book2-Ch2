using DogGoMVC2.Models;
using System.Collections.Generic;

namespace DogGoMVC2.Repositories
{
    public interface IDogRepository
    {
        List<Dog> GetAllDogs();
        Dog GetDogById(int id);

        void AddDog(Dog dog);
        List<Dog> GetDogsByOwnerId(int id);

        //void AddDogWithNull(Dog dog);

    }
}