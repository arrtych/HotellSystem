namespace HotellSystem.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();

        public List<Room> Rooms { get; set; } = new List<Room>();


        public Hotel (int id, string name) { 
            this.Id= id;
            this.Name= name;
        }
        
    }
}
