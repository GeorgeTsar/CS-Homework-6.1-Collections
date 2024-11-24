
Dictionary<string, string> Data = new Dictionary<string, string>();

string a;
do
{
    Console.WriteLine("1. Добавить логин / пароль");
    Console.WriteLine("2. Удалить логин");
    Console.WriteLine("3. Изменение данных");
    Console.WriteLine("4. Показать пароль (надо ввести логин)");
    Console.WriteLine("5. Показать все записи");
    Console.WriteLine("6. Выход");
    Console.WriteLine();

    a = Console.ReadLine();
    switch (a)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Добавить логин, пароль");
            Console.WriteLine("Введите логин -> ");
            string log = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string pass = Console.ReadLine();
            Data.Add (log, pass);
            Console.WriteLine();
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Удалить логин");
            Console.WriteLine("Введите логин, который хотите удалить -> ");
            string i = Console.ReadLine();
            Data.Remove(i);
            Console.WriteLine();
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Изменение данных");
            Console.WriteLine("Введите логин пароля, который хотите изменить -> ");
            string o = Console.ReadLine();
            Console.WriteLine("Введите новый пароль -> ");
            string p = Console.ReadLine();
            Data[o] = p;
            Console.WriteLine();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("Показать пароль (надо ввести логин)");
            Console.WriteLine("Введите логин -> ");
            string q = Console.ReadLine();
            Console.WriteLine(Data[q]);
            Console.WriteLine();
            break;
        case "5":
            Console.Clear();
            Console.WriteLine("Показать все записи");

            foreach (var t in Data.Keys)
            {
                Console.WriteLine(t + ": " + Data[t]);
            }
            Console.WriteLine();
            break;
        case "6":
            Console.Clear();
            Console.WriteLine("Exit");
            break;
        default:
            Console.Clear();
            Console.WriteLine("Нет такого пункта!");
            break;
    }
} while (a != "6");