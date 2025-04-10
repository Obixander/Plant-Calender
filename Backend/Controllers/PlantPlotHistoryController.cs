﻿using DataAccess.Interfaces;
using DataAccess.Repositories;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    /// <summary>
    /// Controller for managing PlantPlotHistory entities.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PlantPlotHistoryController(IPlantPlotHistoryRepository repository) : ControllerBase
    {
        /// <summary>
        /// Retrieves a PlantPlotHistory entity by its instance.
        /// </summary>
        /// <param name="plant">The instance of the PlantPlotHistory entity.</param>
        /// <returns>The PlantPlotHistory entity if found; otherwise, a BadRequest response.</returns>
        [HttpGet]
        public async Task<IActionResult> Get(PlantPlotHistory plant)
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
        /// Retrieves a PlantPlotHistory entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the PlantPlotHistory entity.</param>
        /// <returns>The PlantPlotHistory entity if found; otherwise, a BadRequest response.</returns>
        [HttpGet]
        [Route("/GetBy")]
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
        /// Adds a new PlantPlotHistory entity.
        /// </summary>
        /// <param name="plant">The PlantPlotHistory entity to add.</param>
        /// <returns>A success message if the entity is added; otherwise, a BadRequest response.</returns>
        [HttpPost]
        public async Task<IActionResult> Add(PlantPlotHistory plant)
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
        /// Updates an existing PlantPlotHistory entity.
        /// </summary>
        /// <param name="plant">The PlantPlotHistory entity to update.</param>
        /// <returns>A success message if the entity is updated; otherwise, a BadRequest response.</returns>
        [HttpPut]
        public async Task<IActionResult> Update(PlantPlotHistory plant)
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
        /// Removes a PlantPlotHistory entity.
        /// </summary>
        /// <param name="plant">The PlantPlotHistory entity to remove.</param>
        /// <returns>A success message if the entity is removed; otherwise, a BadRequest response.</returns>
        [HttpDelete]
        public async Task<IActionResult> Remove(PlantPlotHistory plant)
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
