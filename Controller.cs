using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AIS_LAB1
{
    class Controller
    {

        public static void WriteData(Car car, string path, bool is_rewrite)
        {
            using (StreamWriter sw = new StreamWriter(path, is_rewrite, System.Text.Encoding.Default))
            {
                sw.Write("{0}; {1}; {2}; {3}; {4}; {5}; {6};", car.Car_brand, car.Car_model, car.Car_type, car.Body_type, car.Amount_of_horsepower, car.Number_of_doors, car.Is_electric_car);
            }
        }
        public static string ReadData(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    return sr.ReadToEnd();
                }
            }
            catch { 
                return "Проблема с открытием файла"; 
            }
        }

        public static string ReadData(string path, int index)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string[] data;
                    data = sr.ReadToEnd().Split('\r');
                    try
                    {
                        return data[index];
                    }
                    catch (Exception e)
                    {
                        return $"{e.Message}";
                    }
                }
            }
            catch
            {
                return "Проблема с открытием файла";
            }

        }

        public static void DeleteData(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.Write("");
            }
        }
        public static void DeleteData(string path, int index)
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
