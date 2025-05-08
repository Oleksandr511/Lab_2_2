using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2
{
    internal class ComputerFirmClient 
    {
            public int ClientId { get; set; } 
            public string Name { get; set; } 
            public string Email { get; set; } 
            public string PhoneNumber { get; set; } 
            public string Address { get; set; } 

            public ComputerFirmClient()
            {
            }

            public ComputerFirmClient(int clientId, string name, string email, string phoneNumber, string address)
            {
                ClientId = clientId;
                Name = name;
                Email = email;
                PhoneNumber = phoneNumber;
                Address = address;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"ID client: {ClientId}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine($"Phone: {PhoneNumber}");
                Console.WriteLine($"Address: {Address}");
            }
         }
}
