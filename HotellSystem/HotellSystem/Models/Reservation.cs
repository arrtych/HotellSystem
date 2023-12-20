namespace HotellSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<Room> Rooms { get; set; } = new List<Room>(); // may be room

        public Customer Customer { get; set; }


    }
}
