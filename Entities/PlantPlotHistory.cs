using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PlantPlotHistory
    {
        private int plantPlotHistoryId;
        private PlantPlot plantPlot;
        private string history;
        private DateTime timeStamp;

        public int PlantPlotHistoryId { get => plantPlotHistoryId; set => plantPlotHistoryId = value; }
        public PlantPlot PlantPlot { get => plantPlot; set => plantPlot = value; }
        public string History { get => history; set => history = value; }
        public DateTime TimeStamp { get => timeStamp; set => timeStamp = value; }
    }
}
