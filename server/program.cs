string fio = "Изингер Алексей";
string group = "Группа ИСП-242";


Console.WriteLine("Добро пожаловать в консольное приложение!");
Console.WriteLine($"ФИО разработчика: {fio}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Текущая дата и время: {DateTime.Now}");


bool exit = false;
while (!exit)
{
    Console.WriteLine("ГЛАВНОЕ МЕНЮ");
    Console.WriteLine("1 — Показать ФИО");
    Console.WriteLine("2 — Показать группу");
    Console.WriteLine("3 — Показать дату");
    Console.WriteLine("4 — Выход");
    Console.Write("Выберите пункт меню (1-4): ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine($"\n[ФИО]: {fio}");
            break;
        case "2":
            Console.WriteLine($"\n[Группа]: {group}");
            break;
        case "3":
            Console.WriteLine($"\n[Текущая дата]: {DateTime.Now.ToShortDateString()}");
            break;
        case "4":
            Console.WriteLine("\nЗавершение работы программы. До свидания!");
            exit = true;
            break;
        default:
            Console.WriteLine("\nОшибка: Неверный выбор. Пожалуйста, введите цифру от 1 до 4.");
            break;
    }
}