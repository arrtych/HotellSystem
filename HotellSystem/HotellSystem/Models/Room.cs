namespace HotellSystem.Models
{
    public class Room
    {
        public int Id { get; set; }
        
        public int Number { get; set; }
        public bool isFree { get; set; } = true;

        public int BedsAmount { get; set; } // type or enum ? 

        public double Price { get; set; }

        public int HotelId { get; set; }


        public bool IsSuitable(Customer customer, CreateReservationRequestModel requestModel) // check by date
        {
            //check customer and price +
            //date after today
            bool result = false;
            //if (room != null && customer != null) //check that room is free , check that date are suitable // price -> check if customer can pay for room
            if (customer != null && requestModel != null) 
            {
                
                if (customer?.Budget >= this.Price)
                {
                    if(requestModel.StartDate > DateTime.Today && requestModel.EndDate > DateTime.Today)
                    {
                        if (this.isFree)
                        {
                            result = true;
                        } else
                        {
                            Console.WriteLine("Room is not free");
                        }
                    } else
                    {
                        Console.WriteLine("Date is wrong");
                    }
                } else
                {
                    Console.WriteLine("Customer don't have enough money");
                }

            } 
            


            return result;

        }
    }
}
