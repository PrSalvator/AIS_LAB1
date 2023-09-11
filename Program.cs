using System;
using System.Collections.Generic;
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
        }
    }
}
