using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Vehicle
    {
        public float SpeedKMH { get; private set; }
        public float PriceFor1KM { get; private set; }
        public string NameVehicle { get; private set; }

        private protected void AddNameVehicle(string name) => NameVehicle = name;

        public string AddSpeedKMH(float speedKMH)
        {
            if (speedKMH > 0)
            {
                SpeedKMH = speedKMH;
                return $"Скорость {NameVehicle} была задана - {SpeedKMH}";
            }

            throw new Exception("Похоже вы задали скорость ниже или равную 0");
        }

        public string AddPriceFor1KM(float priceFor1KM)
        {
            if (priceFor1KM >= 0)
            {
                PriceFor1KM = priceFor1KM;
                return $"Цена за 1 км расстояния на {NameVehicle} - {PriceFor1KM}";
            }

            throw new Exception("Похоже вы задали цену ниже 0");
        }

        public float GetTimeDelivery(float distance)
        {
            if (distance > 0 && SpeedKMH > 0)
            {
                return distance / SpeedKMH;
            }
            else
            {
                throw new Exception("Дистанция меньше 0 или скорость меньше или равна 0.");
            }
        }

        public float GetFullPrice(float distance)
        {
            if (distance > 0 && PriceFor1KM >= 0)
            {
                return distance * PriceFor1KM;
            }
            else
            {
                throw new Exception("Дистанция меньше 0 или цена за 1 км пути меньше 0.");
            }
        }

        public override string ToString()
        {
            if (SpeedKMH > 0 && PriceFor1KM >= 0)
                return $"{NameVehicle}: Скорость - {SpeedKMH}; Цена за 1 км пути - {PriceFor1KM}";

            return $"{NameVehicle}: Скорость - не установлена; Цена за 1 км пути - не установлена.";
        }
    }
}
