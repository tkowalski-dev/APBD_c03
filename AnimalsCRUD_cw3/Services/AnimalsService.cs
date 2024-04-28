﻿using AnimalsCRUD_cw3.Model;
using AnimalsCRUD_cw3.Repositories;

namespace AnimalsCRUD_cw3.Services;

public class AnimalsService : IAnimalsService
{
    private readonly IAnimalsRepository _animalsRepository;
    
    public AnimalsService(IAnimalsRepository animalsRepository)
    {
        _animalsRepository = animalsRepository;
    }
    
    public IEnumerable<Animal> GetAnimals()
    {
        return _animalsRepository.GetAnimals();
    }
    
    public int CreateAnimal(Animal animal)
    {
        return _animalsRepository.CreateAnimal(animal);
    }

    public Animal? GetAnimal(int idAnimal)
    {
        return _animalsRepository.GetAnimal(idAnimal);
    }

    public int UpdateAnimal(Animal animal)
    {
        return _animalsRepository.UpdateAnimal(animal);
    }

    public int DeleteAnimal(int idAnimal)
    {
        return _animalsRepository.DeleteAnimal(idAnimal);
    }
}