using DataAccess.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class PlantRepository(DataContext dataContext) : GenericRepository<Plant>(dataContext),IPlantRepository
    {
       public async Task<List<Plant>> GetAllBy(DateOnly Month)
        {
            try
            {
                return await dataContext.Plants.Where(x => x.PlantingDate.Month == Month.Month || x.PlantingDate.Month == Month.Month+1 || x.MoveTime.Month == Month.Month || x.MoveTime.Month == Month.Month + 1 || x.HarvestTime.Month == Month.Month || x.HarvestTime.Month == Month.Month + 1).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

    }
}
