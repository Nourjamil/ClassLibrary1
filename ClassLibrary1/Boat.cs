namespace ClassLibrary1
{
    public class Boat
    {
        public int BoatId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string SailNumber { get; set; }
        public string EngineInfo { get; set; }
        public int BuildYear { get; set; }
        public bool IsAvailable { get; set; }

        public List<Maintenance> MaintenanceLog { get; set; } = new();
    }
}
