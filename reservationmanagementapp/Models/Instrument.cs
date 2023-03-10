namespace reservationmanagementapp.Models
{
    public class Instrument
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public IEnumerable<Room>? Rooms { get; set; }
    }

}
