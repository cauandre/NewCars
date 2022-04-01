

using NewCarsLib.Model.Enum;

namespace NewCarsLib
{
    public class Car
    {
        public int Id { get; set; }

        public Color Color { get; set; }

        public Brand Brand { get; set; }

        public ModelCar ModelCar { get; set; }

        public int Year { get; set; }

        public decimal PriceRent { get; set; }

        public decimal PriceSell { get; set; }


    }
}