using DataAccess.Interfaces;
using DataAccess.Repositories;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Backend.Controllers
{
    /// <summary>
    /// Controller for managing Plant entities.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PlantController(IPlantRepository repository) : ControllerBase
    {
        /// <summary>
        /// Retrieves a plant based on the provided plant entity.
        /// </summary>
        /// <param name="plant">The plant entity to filter by.</param>
        /// <returns>A plant that match the provided plant entity.</returns>
        [HttpGet]
        public async Task<IActionResult> Get(Plant plant)
        {
            try
            {
                return Ok(await repository.GetBy(plant));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Retrieves a plant by its ID.
        /// </summary>
        /// <param name="id">The ID of the plant to retrieve.</param>
        /// <returns>The plant with the specified ID.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(int id)
        {
            try
            {
                return Ok(await repository.GetBy(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Adds a new plant.
        /// </summary>
        /// <param name="plant">The plant entity to add.</param>
        /// <returns>A success message if the plant is added successfully.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(Plant plant)
        {
            try
            {
                await repository.Add(plant);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Updates an existing plant.
        /// </summary>
        /// <param name="plant">The plant entity to update.</param>
        /// <returns>A success message if the plant is updated successfully.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(Plant plant)
        {
            try
            {
                await repository.Update(plant);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Removes an existing plant.
        /// </summary>
        /// <param name="plant">The plant entity to remove.</param>
        /// <returns>A success message if the plant is removed successfully.</returns>
        [HttpDelete]
        public async Task<IActionResult> Remove(Plant plant)
        {
            try
            {
                await repository.Remove(plant);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("/getAll")]
        public async Task<IActionResult> GetAllBy(DateOnly month)
        {
            try
            {
                return Ok(await repository.GetAllBy(month));
            }
            catch
            {
                throw;
            }
        }
    }
}
