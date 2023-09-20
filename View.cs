using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB1
{
    class View
    {
        private static bool Is_in_interv(bool is_in_interv) {
            if (!is_in_interv)
            {
                return false;
            }
            return true;
        }
        private static bool Is_letter(bool is_letter)
        {
            if (!is_letter)
            {
                return false;
            }
            return true;
        }
        private static void Main(string[] args)
        {
            string choose;
            string path = "cars.csv";
            string index;
            while (true)
            {
                Console.WriteLine(
                    "Нажмите 1 для добавления автомобиля \n" +
                    "Нажмите 2 для вывода всех автомобилей \n" +
                    "Нажмите 3 для вывода автомобиля по номеру записи \n" +
                    "Нажмите 4 для удаления всех записей \n" +
                    "Нажмите 5 для удаления автомобилей по номеру записи\n" +
                    "Нажмите esc для выхода из программы \n"
                    );
                var button = Console.ReadKey(true).Key;
                if (button == ConsoleKey.Escape) break;

                switch (button)
                {
                    
                    case ConsoleKey.D1:
                        Car car = new Car();

                        Console.WriteLine("Введите марку автомобиля");
                        car.Car_brand = Console.ReadLine();

                        Console.WriteLine("Введите модель автомобиля");
                        car.Car_model = Console.ReadLine();

                        Console.WriteLine("Выберите тип кузова");
                        foreach (var body in Car.Bodies)
                        {
                            Console.WriteLine($"{ body.Key } - { body.Value }");
                        }

                        choose = Console.ReadLine();
                        if (!Is_letter(Validator.Is_Letter(choose)) && !Is_in_interv(Validator.In_Interval(1, 18, choose)))
                        {
                            break;
                        }
                        car.Body_type = Car.Bodies[int.Parse(choose)];

                        Console.WriteLine("Выберите тип автомобиля");
                        foreach (var type in Car.Types)
                        {
                            Console.WriteLine($"{ type.Key } - { type.Value }");
                        }
                        choose = Console.ReadLine();

                        if (!Is_in_interv(Validator.In_Interval(1, 5, choose)) && !Is_letter(Validator.Is_Letter(choose))) {
                            Console.WriteLine("Некорректный ввод");
                            break;
                        }
                        car.Car_type = Car.Types[int.Parse(choose)];


                        Console.WriteLine("Введите количество дверей");
                        choose = Console.ReadLine();
                        if (!Is_letter(Validator.Is_Letter(choose))) {
                            Console.WriteLine("Некорректный ввод");
                            break; 
                        }
                        car.Number_of_doors = int.Parse(choose);
                        
                        Console.WriteLine("Введите количество лошадиных сил");
                        choose = Console.ReadLine();
                        if (!Is_letter(Validator.Is_Letter(choose)))
                        {
                            Console.WriteLine("Некорректный ввод");
                            break;
                        }
                        car.Amount_of_horsepower = int.Parse(choose);

                        Console.WriteLine("Машина работает на электричестве? [Y/N]");
                        ConsoleKey key = new ConsoleKey();
                        while (true)
                        {
                            key = Console.ReadKey(true).Key;
                            if (key == ConsoleKey.Y)
                            {
                                car.Is_electric_car = true;
                                break;
                            }
                            else if (key == ConsoleKey.N)
                            { 
                                car.Is_electric_car = false;
                                break;
                            }
                        }

                        Console.WriteLine("Перезаписать данные файла? [Y/N]");
                        while (true)
                        {
                            key = Console.ReadKey(true).Key;
                            if (key == ConsoleKey.Y)
                            {
                                Controller.WriteData(car, path, false);
                                break;
                            }
                            else if (key == ConsoleKey.N)
                            {
                                Controller.WriteData(car, path, true);
                                break;
                            }
                        }
                        Console.WriteLine();
                        break;

                    case ConsoleKey.D2:
                        string[] data = Controller.ReadData(path).Split('\n');
                        int counter = 0;
                        foreach (string str in data)
                        {
                            string _str = str.Replace(";", "");
                            if (_str != "")
                            {
                                Console.WriteLine($"{counter} {_str}");
                                counter++;
                            }
                        }
                        Console.WriteLine();
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine("Введите номер записи");
                        index = Console.ReadLine();
                        if (!Is_letter(Validator.Is_Letter(index))) {
                            Console.WriteLine("Некорректный ввод");
                            break; 
                        }
                        Console.WriteLine(Controller.ReadData(path, int.Parse(index)).Replace(";", ""));
                        break;

                    case ConsoleKey.D4:
                        Controller.DeleteData(path);
                        Console.WriteLine("Записи удалены");
                        Console.WriteLine();
                        break;

                    case ConsoleKey.D5:
                        Console.WriteLine("Введите номер записи");
                        index = Console.ReadLine();
                        if (!Is_letter(Validator.Is_Letter(index))) {
                            Console.WriteLine("Некорректный ввод");
                            break; 
                        }
                        Controller.DeleteData(path, int.Parse(index));
                        break;       
                }
            }
        }

    }
}
