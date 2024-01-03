using HotellSystem.Models;
using System.Xml.Linq;

namespace HotellSystem.Service
{
    public class HotellService
    {
        public Hotell hotell { get; set; }
        public List<Room> rooms { get; set; }

        public List<Customer> customers { get; set; }

        public HotellService() { 
            this.InitHotellSystem();
        }

        public void InitHotellSystem()
        {
            this.hotell = this.InitHotell(1,"Hotell Express");
            this.rooms = this.InitRooms();
            this.customers = this.InitCustomers();
        }


        public Hotell InitHotell(int id, string name)
        {
            Hotell hotell= new Hotell(id, name );
            return hotell;
        }

        public List<Room> InitRooms() { 
            
            List<Room> list = new List<Room>();

            Room room1 = new Room();
            room1.Id = 1;
            room1.isFree = true;
            room1.Number = 101;
            room1.BedsAmount = 1;
            room1.Price = 200;
            list.Add(room1);

            Room room2 = new Room();
            room2.Id = 2;
            room2.isFree = true;
            room2.Number = 201;
            room2.BedsAmount = 2;
            room1.Price = 280;
            list.Add(room2);

            Room room3 = new Room();
            room3.Id = 2;
            room3.isFree = true;
            room3.Number = 301;
            room3.BedsAmount = 3;
            room3.Price = 400;
            list.Add(room3);

            return list;
        }

        public List<Customer> InitCustomers() { 
            
            List<Customer> list = new List<Customer>();
            Customer customer= new Customer();
            customer.CustomerId = 1;
            customer.PersonalCode = "39212233718";
            customer.FirstName = "Artur";
            customer.LastName = "Lipin";
            customer.Email = "artur@gmail.com";
            customer.Budget = 500;

            list.Add(customer);

            return list;
        
        }
    }
}
