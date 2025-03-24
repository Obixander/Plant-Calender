﻿using DataAccess.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class PlantRepository(DataContext dataContext) : GenericRepository<Plant>(dataContext),IPlantRepository
    {

    }
}
