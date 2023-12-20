namespace HotellSystem.Models
{
    public class Room
    {
        public int Id { get; set; }
        
        public int Number { get; set; }
        public bool isFree { get; set; } = true;

        public int BedsAmount { get; set; } // type or enum ? 

        public double Price { get; set; }

    }
}
