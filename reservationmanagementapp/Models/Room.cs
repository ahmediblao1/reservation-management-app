using System.Diagnostics.Metrics;

namespace reservationmanagementapp.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime ReservationDate { get; set; }
        public Instrument? instrument { get; set; }
        public  int InstrumentId { get; set; }
    }

}
