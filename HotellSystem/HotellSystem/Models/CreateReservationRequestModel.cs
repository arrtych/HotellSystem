namespace HotellSystem.Models
{
    public class CreateReservationRequestModel
    {
        public int RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int CustomerId { get; set; }
        // Add other parameters as needed
    }
}
