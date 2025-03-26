using DataAccess.Repositories;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    /// <summary>
    /// Controller for managing PlantPlot entities.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PlantPlotController(PlantPlotRepository repository) : ControllerBase
    {
        /// <summary>
        /// Retrieves a PlantPlot entity by its instance.
        /// </summary>
        /// <param name="plant">The instance of the PlantPlot entity.</param>
        /// <returns>The PlantPlot entity if found; otherwise, a BadRequest response.</returns>
        [HttpGet]
        public async Task<IActionResult> Get(PlantPlot plant)
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
        /// Retrieves a PlantPlot entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the PlantPlot entity.</param>
        /// <returns>The PlantPlot entity if found; otherwise, a BadRequest response.</returns>
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
        /// Adds a new PlantPlot entity.
        /// </summary>
        /// <param name="plant">The PlantPlot entity to add.</param>
        /// <returns>A success message if the entity is added; otherwise, a BadRequest response.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(PlantPlot plant)
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
        /// Updates an existing PlantPlot entity.
        /// </summary>
        /// <param name="plant">The PlantPlot entity to update.</param>
        /// <returns>A success message if the entity is updated; otherwise, a BadRequest response.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(PlantPlot plant)
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
        /// Removes a PlantPlot entity.
        /// </summary>
        /// <param name="plant">The PlantPlot entity to remove.</param>
        /// <returns>A success message if the entity is removed; otherwise, a BadRequest response.</returns>
        [HttpDelete]
        public async Task<IActionResult> Remove(PlantPlot plant)
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
    }
}
