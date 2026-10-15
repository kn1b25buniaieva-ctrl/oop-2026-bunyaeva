using System.Text;
using AutoServiceApp.Models;

// Настройка кодировки UTF-8 для консоли
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

// Создание объектов Car
Car car1 = new()
{
    Brand = "BMW",
    Model = "X5",
    Year = 2021
};

Car car2 = new()
{
    Brand = "Audi",
    Model = "A6",
    Year = 2019
};

// Создание объектов Customer
Customer customer1 = new()
{
    Name = "Олександр Коваленко"
};

Customer customer2 = new()
{
    Name = "Марія Бойко"
};

// Вывод информации
Console.WriteLine("Автомобілі:");
Console.WriteLine($"{car1.Brand} {car1.Model}, {car1.Year} рік");
Console.WriteLine($"{car2.Brand} {car2.Model}, {car2.Year} рік");

Console.WriteLine("\nКлієнти автосервісу:");
Console.WriteLine($"Власник: {customer1.Name}");
Console.WriteLine($"Власник: {customer2.Name}");