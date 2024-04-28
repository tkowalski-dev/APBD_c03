using AnimalsCRUD_cw3.Model;
using AnimalsCRUD_cw3.Repositories;

namespace AnimalsCRUD_cw3.Services;

public class AnimalsService : IAnimalsService
{
    private readonly IAnimalsRepository _animalsRepository;
    
    public AnimalsService(IAnimalsRepository animalsRepository)
    {
        _animalsRepository = animalsRepository;
    }
    
    public IEnumerable<Animal> GetAnimals(string orderBy)
    {
        orderBy = orderBy.ToLower();
        List<string> allowedColumns = new() { "idanimal", "name", "description", "category", "area" };
        if (!allowedColumns.Contains(orderBy))
        {
            throw new ArgumentException($"Order by {orderBy} denied!");
        }
        return _animalsRepository.GetAnimals(orderBy);
    }
    
    public int CreateAnimal(Animal animal)
    {
        return _animalsRepository.CreateAnimal(animal);
    }

    public int UpdateAnimal(int idAnimal, Animal animal)
    {
        return _animalsRepository.UpdateAnimal(idAnimal, animal);
    }

    public int DeleteAnimal(int idAnimal)
    {
        return _animalsRepository.DeleteAnimal(idAnimal);
    }
}