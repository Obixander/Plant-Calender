using DataAccess.Repositories;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantPlotHistoryController(PlantPlotHistoryRepository repository) : ControllerBase
    {
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

        [HttpGet]
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
