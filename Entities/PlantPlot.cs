using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PlantPlot
    {
        private int plantPlotId;
        private Plant plant;
        private DateTime lastWatered;
        private DateTime lastFertilized;
        private List<PlantPlotHistory> history;

        public int PlantPlotId { get => plantPlotId; set => plantPlotId = value; }
        public Plant Plant { get => plant; set => plant = value; }
        public DateTime LastWatered { get => lastWatered; set => lastWatered = value; }
        public DateTime LastFertilized { get => lastFertilized; set => lastFertilized = value; }
        public List<PlantPlotHistory> History { get => history; set => history = value; }
    }
}
