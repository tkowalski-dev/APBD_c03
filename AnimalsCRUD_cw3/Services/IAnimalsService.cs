using AnimalsCRUD_cw3.Model;

namespace AnimalsCRUD_cw3.Services;

public interface IAnimalsService
{
    IEnumerable<Animal> GetAnimals();
    int CreateAnimal(Animal student);
    Animal? GetAnimal(int idAnimal);
    int UpdateAnimal(Animal student);
    int DeleteAnimal(int idAnimal);
}