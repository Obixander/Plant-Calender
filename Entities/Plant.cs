namespace Entities
{
    public class Plant
    {
        private string englishName;
        private string latinName;
        private string family;
        private string description;
        private string image;
        private DateOnly plantingDate;
        private DateOnly moveTime;
        private DateOnly harvestTime;

        public string EnglishName { get => englishName; set => englishName = value; }
        public string LatinName { get => latinName; set => latinName = value; }
        public string Family { get => family; set => family = value; }
        public string Description { get => description; set => description = value; }
        public string Image { get => image; set => image = value; }
        public DateOnly PlantingDate { get => plantingDate; set => plantingDate = value; }
        public DateOnly MoveTime { get => moveTime; set => moveTime = value; }
        public DateOnly HarvestTime { get => harvestTime; set => harvestTime = value; }
    }
}
