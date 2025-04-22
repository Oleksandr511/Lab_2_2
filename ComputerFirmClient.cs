using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Пояснення:
//Клас ComputerFirmClient включає властивості для зберігання інформації про клієнта, такі як ClientId, Name, Email, PhoneNumber і Address.
//Є два конструктори: за замовчуванням і з параметрами для ініціалізації об'єкта.
//Метод DisplayInfo відображає інформацію про клієнта в консоль.
//Цей клас можна розширити, додаючи додатковий функціонал, наприклад, методи для обробки замовлень чи взаємодії з іншими частинами програми.

namespace Lab_2_2
{
    internal class ComputerFirmClient 
    {
            // Властивості клієнта
            public int ClientId { get; set; } // Унікальний ідентифікатор клієнта
            public string Name { get; set; } // Ім'я клієнта
            public string Email { get; set; } // Електронна пошта клієнта
            public string PhoneNumber { get; set; } // Номер телефону клієнта
            public string Address { get; set; } // Адреса клієнта

            // Конструктор за замовчуванням
            public ComputerFirmClient()
            {
            }

            // Конструктор з параметрами
            public ComputerFirmClient(int clientId, string name, string email, string phoneNumber, string address)
            {
                ClientId = clientId;
                Name = name;
                Email = email;
                PhoneNumber = phoneNumber;
                Address = address;
            }

            // Метод для відображення інформації про клієнта
            public void DisplayInfo()
            {
                Console.WriteLine($"ID клієнта: {ClientId}");
                Console.WriteLine($"Ім'я: {Name}");
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine($"Телефон: {PhoneNumber}");
                Console.WriteLine($"Адреса: {Address}");
            }
         }
}
