using AnimalsCRUD_cw3.Model;
using AnimalsCRUD_cw3.Services;
using Microsoft.AspNetCore.Mvc;

namespace AnimalsCRUD_cw3.Controllers;
 
[Route("api/[controller]")]
[ApiController]
public class AnimalsController : ControllerBase
{
    private IAnimalsService _animalsService;

    public AnimalsController(IAnimalsService animalsService)
    {
        _animalsService = animalsService;
    }
    
    /// <summary>
    /// Endpoints used to return list of animals.
    /// </summary>
    /// <returns>List of animals</returns>
    [HttpGet]
    public IActionResult GetAnimals(string orderBy = "name")
    {
        var animals = _animalsService.GetAnimals(orderBy);
        return Ok(animals);
    }
    
    /// <summary>
    /// Endpoint used to create a animal.
    /// </summary>
    /// <param name="animal">New animal data</param>
    /// <returns>201 Created</returns>
    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        var affectedCount = _animalsService.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
    
    /// <summary>
    /// Endpoint used to update a animal.
    /// </summary>
    /// <param name="id">Id of a animal</param>
    /// <param name="animal">204 No Content</param>
    /// <returns></returns>
    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var affectedCount = _animalsService.UpdateAnimal(id, animal);
        return affectedCount > 0 ? NoContent() : NotFound();
    }
    
    /// <summary>
    /// Endpoint used to delete a animal.
    /// </summary>
    /// <param name="id">Id of a animal</param>
    /// <returns>204 No Content or 404 Not Found</returns>
    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var affectedCount = _animalsService.DeleteAnimal(id);
        return affectedCount > 0 ? NoContent() : NotFound();
    }
}

