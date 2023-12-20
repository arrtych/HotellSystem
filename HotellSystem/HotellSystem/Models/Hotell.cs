namespace HotellSystem.Models
{
    public class Hotell
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();

        public List<Room> Rooms { get; set; } = new List<Room>();
    }
}
