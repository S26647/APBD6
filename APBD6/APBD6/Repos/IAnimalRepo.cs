using APBD6.Models;

namespace APBD6.Repos;

public interface IAnimalRepo
{
    IEnumerable<Animal> GetAnimals(string orderBy);
    int CreateAnimal(AnimalDTO animalDTO);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int idAnimal);
}