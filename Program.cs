// See https://aka.ms/new-console-template for more information

using Lab_2_2;

Console.WriteLine("Hello, World!");

ComputerFirmClient client = new ComputerFirmClient();
client.DisplayInfo(); // Виклик методу, якщо є
Console.WriteLine(client.Address); // Отримання властивості