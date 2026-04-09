using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Party myParty = new Party();
        EventLog myLog = new EventLog();

        myParty.Add(new Character("Kira", "Witch", 10, 100, 500, "Active"));
        myParty.Add(new Character("Ihor", "Mag", 12, 0, 209, "Dead"));
        myParty.Add(new Character("Arina", "Witch", 8, 15, 200, "Active"));


        myLog.AddEvent(new Event(1, "Fight", "Battle", -35));
        myLog.AddEvent(new Event(2, "Break", "Heal", 20));

        bool start= true;

        while (start)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("1 - Показати всіх гравців");
            Console.WriteLine("2 - Показати активних гравців");
            Console.WriteLine("3 - Поранені");
            Console.WriteLine("4 - Хронологія подій ");
            Console.WriteLine("5 - Пошук за типом події");
            Console.WriteLine("6 - Отримати список лише імен");
            Console.WriteLine("0 - Вихід");
            Console.WriteLine("Введіть цифру: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Усі гравці");
                    foreach (var ch in myParty) 
                        Console.WriteLine($"{ch.Name} ({ch.Role}), Здоров'я: {ch.Health}, Золото: {ch.CountOfGold}");
                    break;

                case "2":
                    Console.WriteLine("Aктивні гравці");
                    foreach (var ch in myParty.GetActiveCharacters())
                        Console.WriteLine(ch.Name);
                    break;

                case "3":
                    Console.WriteLine("Герої з низьким здоров'ям (менше 50)");
                    foreach (var ch in myParty.GetCharactersBelowCertainValue(50))
                        Console.WriteLine($" у {ch.Name} залишилось: {ch.Health} здоров'я");
                    break;

                case "4":
                    Console.WriteLine("Події у хронологічному порядку");
                    foreach (var ev in myLog.СhronologicalEvents())
                        Console.WriteLine($"Крок {ev.MoveNumber}: {ev.Description} [{ev.TypeOfEvent}]");
                    break;

                case "5":
                    Console.Write("Введіть тип події для пошуку(Battle or Heal): ");
                    string type = Console.ReadLine();
                    Console.WriteLine($"Події типу: {type}");
                    foreach (var ev in myLog.GetEventsByType(type))
                        Console.WriteLine($"- {ev.Description}, зміна: {ev.ChangeCharacteristic}");
                    break;
                case "6":
                    Console.WriteLine("--- Список імен усіх героїв ---");
                    var names = myParty.GetHeroNames(); 
                    Console.WriteLine("Герої: " + string.Join(", ", names));
                    break;

                case "0":
                    Console.WriteLine("ЗАВЕРШЕНО");
                    start = false; 
                    break;
            }
            if (start)
            {
                Console.WriteLine("\nНатисніть Enter, щоб продовжити...");
                Console.ReadLine();
            }
        }
    }
}
