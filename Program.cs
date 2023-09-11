using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            var car_type = new Dictionary<int, string>
            {
                { 1, "Легковой"},
                { 2, "Грузовой"},
                { 3, "Грузопассажирский"},
                { 4, "Автобус"},
                { 5, "Спецтранспорт"}
            };
            var body_model = new Dictionary<int, string>
            {
                { 1, "Седан"},
                { 2, "Купе"},
                { 3, "Хэтчбек"},
                { 4, "Лифтбек"},
                { 5, "Фастбэк"},
                { 6, "Универсал"},
                { 7, "Кроссовер"},
                { 8, "Внедорожник"},
                { 9, "Пикап"},
                { 10, "Легковой фургон"},
                { 11, "Минивэн"},
                { 12, "Компактвэн"},
                { 13, "Кабриолет"},
                { 14, "Родстер"},
                { 15, "Тарга"},
                { 16, "Ландо"},
                { 17, "Лимузин"},
                { 18, "Микровэн"}
            };

            WriteData(new Car(1, 1, "asd", "asda", "asd", "asas",true), @"C:\Users\пр\Desktop\лабы\Архитектура ИС\AIS_LAB1\cars.csv", true);
        }
        private static void WriteData(Car car, string path, bool is_rewrite)
        {
            using (StreamWriter sw = new StreamWriter(path, is_rewrite, System.Text.Encoding.Default))
            {
                sw.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", car.Car_model, car.Car_brand, car.Car_type, car.Body_type, car.Amount_of_horsepower, car.Number_of_doors, car.Is_electric_car);
            }
        }
    }
}
