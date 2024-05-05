using APBD6.Models;
using APBD6.Repos;
using Microsoft.AspNetCore.Mvc;

namespace APBD6.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnimalsController : ControllerBase
{
    private IAnimalRepo _animalRepository;

    public AnimalsController(IAnimalRepo animalRepository)
    {
        _animalRepository = animalRepository;
    }

    [HttpGet]
    public IActionResult GetAnimals(string? orderBy)
    {
        var animals = _animalRepository.GetAnimals(orderBy);
        return Ok(animals);
    }

    [HttpPost]
    public IActionResult CreateAnimal(AnimalDTO animalDTO)
    {
        var affectedCount = _animalRepository.CreateAnimal(animalDTO);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(Animal animal)
    {
        var affectedCount = _animalRepository.UpdateAnimal(animal);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var affectedCount = _animalRepository.DeleteAnimal(id);
        return NoContent();
    }
}