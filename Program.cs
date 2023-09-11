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

            Console.ReadKey();
        }
        private static void WriteData(Car car, string path, bool is_rewrite)
        {
            using (StreamWriter sw = new StreamWriter(path, is_rewrite, System.Text.Encoding.Default))
            {
                sw.WriteLine("{0}; {1}; {2}; {3}; {4}; {5}; {6};", car.Car_model, car.Car_brand, car.Car_type, car.Body_type, car.Amount_of_horsepower, car.Number_of_doors, car.Is_electric_car);
            }
        }
        private static string ReadData(string path)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                return sr.ReadToEnd();
            }
        }
        private static string ReadData(string path, int index)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string[] data;
                data = sr.ReadToEnd().Split('\r');
                try
                {
                    return data[index];
                }
                catch(Exception ex)
                {
                    return "";
                }
            }
            
        }

        private static void DeleteData(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.Write("");
            }
        }
        private static void DeleteData(string path, int start, int finish)
        {
            string[] data;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                data = sr.ReadToEnd().Split('\r');
            }
            DeleteData(path);
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (i < start && i > finish)
                    {
                        sw.Write(data[i]);
                    }
                }
            }
        }
        private static void DeleteData(string path, int index)
        {
            string[] data;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                data = sr.ReadToEnd().Split('\r');
            }
            DeleteData(path);
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (i != index)
                    {
                        sw.Write(data[i]);
                    }
                }
            }
        }
    }
}
