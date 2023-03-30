using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    internal class Car
    {
        private string _brand;
        private string _model;
        private double _fuelcapacity;
        private double _nowcapacity;
        private double _fuelfor1km;
        public string Brand { get
            {
                return this._brand;
            }
            set {
                if (value.Length >= 2 && value.Length <= 200)
                    this._brand = value;
            } }
        public string Model { 

            get=>this._model;
            
            set
            {
                if (value.Length >= 1 && value.Length <= 10)
                    this._model = value;
            } }
        public double FuelCapacity { get
            {
                return this._fuelcapacity;
            }
            set
            {
                if (value >= 30 && value <= 200)
                    this._fuelcapacity = value;
            } }
        public double NowCapacity { get
            {
                return this._nowcapacity;
            }
            set
            {
                if (value >= 0 && value <= 200)
                    this._nowcapacity = value;
            } }
        public double FuelFor1km { get;
            private set;  }
        public string Drive(double km) {
            this.FuelFor1km = this._nowcapacity / km;
            
            return ($"Brand : {Brand} - Model : {Model} - FuelCapacity : {FuelCapacity} - NowCapacity : {NowCapacity} - FuelFor1km : {FuelFor1km}");
        }
        public string GetInfo()
        {
            return ($"Brand : {Brand} - Model : {Model} - FuelCapacity : {FuelCapacity} - NowCapacity : {NowCapacity} - FuelFor1km : {FuelFor1km}");
        }
    }
}
