using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Plant> Plants { get; set; }
        public DbSet<PlantPlot> Plantplots { get; set; }
        public DbSet<PlantPlotHistory> PlantPlotHistories { get; set; }

        private string connection = "";
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plant>().HasData(
            new Plant
            {
                PlantId = 1,
                EnglishName = "Tomato",
                LatinName = "Solanum lycopersicum",
                Family = "Solanaceae",
                Description = "A red, edible fruit often used in salads and cooking.",
                Image = "tomato.jpg",
                PlantingDate = new DateOnly(2024, 3, 1),
                MoveTime = new DateOnly(2024, 5, 1),
                HarvestTime = new DateOnly(2024, 7, 15)
            },
            new Plant
            {
                PlantId = 2,
                EnglishName = "Carrot",
                LatinName = "Daucus carota",
                Family = "Apiaceae",
                Description = "A root vegetable, usually orange in color.",
                Image = "carrot.jpg",
                PlantingDate = new DateOnly(2024, 4, 10),
                MoveTime = new DateOnly(2024, 5, 20),
                HarvestTime = new DateOnly(2024, 8, 30)
            },
            new Plant
            {
                PlantId = 3,
                EnglishName = "Lettuce",
                LatinName = "Lactuca sativa",
                Family = "Asteraceae",
                Description = "A leafy green vegetable often used in salads.",
                Image = "lettuce.jpg",
                PlantingDate = new DateOnly(2024, 2, 15),
                MoveTime = new DateOnly(2024, 3, 20),
                HarvestTime = new DateOnly(2024, 5, 10)
            },
            new Plant
            {
                PlantId = 4,
                EnglishName = "Basil",
                LatinName = "Ocimum basilicum",
                Family = "Lamiaceae",
                Description = "A fragrant herb used in cooking, especially in Italian cuisine.",
                Image = "basil.jpg",
                PlantingDate = new DateOnly(2025, 3, 5),
                MoveTime = new DateOnly(2025, 3, 20),
                HarvestTime = new DateOnly(2025, 4, 15)
            },
            new Plant
            {
                PlantId = 5,
                EnglishName = "Strawberry",
                LatinName = "Fragaria × ananassa",
                Family = "Rosaceae",
                Description = "A sweet red fruit often eaten fresh or used in desserts.",
                Image = "strawberry.jpg",
                PlantingDate = new DateOnly(2025, 3, 10),
                MoveTime = new DateOnly(2025, 3, 25),
                HarvestTime = new DateOnly(2025, 4, 30)
            },
            new Plant
            {
                PlantId = 6,
                EnglishName = "Spinach",
                LatinName = "Spinacia oleracea",
                Family = "Amaranthaceae",
                Description = "A leafy green vegetable rich in iron and vitamins.",
                Image = "spinach.jpg",
                PlantingDate = new DateOnly(2025, 4, 1),
                MoveTime = new DateOnly(2025, 4, 15),
                HarvestTime = new DateOnly(2025, 5, 10)
            }
        );
            base.OnModelCreating(modelBuilder);
        }

    }
}
