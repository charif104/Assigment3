using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment3
{
 public class FuelCalculater
    {
        private double currReading;
        private double prevReading;
        private double fuelAmount;
        private double unitPrice;
        

        public FuelCalculater()
        {
            

        }

        public double CurrReading
        {
            get
            {
                return currReading;
            }

            set
            {
                if(currReading>=0 )
                currReading = value;
            }
        }

        public double FuelAmount
        {
            get
            {
                return fuelAmount;
            }

            set
            {
                fuelAmount = value;
            }
        }

        public double PrevReading
        {
            get
            {
                return prevReading;
            }

            set
            {
                prevReading = value;
            }
        }

        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }

            set
            {
                unitPrice = value;
            }
        }

        public double CalcFuelConsumptionPerKM()
        {
            double km = currReading - prevReading;
            double litPerKm = fuelAmount / km;
            return Math.Round(litPerKm,2);
        }
        public double CalcConsumptionKilometerPerLiter()
        {
            double km = currReading - prevReading;
            double KmPerLit = km / fuelAmount;
            return KmPerLit;
        }

        public double CalcConsumptionKilometerPerMetricMile()
        {
            double km = currReading - prevReading;
            double litPerKm = fuelAmount / km;
            return litPerKm;
            const double KmToMileFactor = 0.621371192;
            double litPerMetricMile = litPerKm / KmToMileFactor;
            return litPerMetricMile;
        }

         public double CalcFuelConsumptionPerSweMil()
        {
            double km = currReading - prevReading;
            double litPerKm = fuelAmount / km;
            double literPerSweMile = litPerKm * 10;
            return literPerSweMile;
        } 
        public double CalcCostPerKm()
        {
            double km = currReading - prevReading;
            double litPerKm = fuelAmount / km;
            double costPerKM = litPerKm * unitPrice; 
            return costPerKM;
        }

        private bool ValidateOdometerValues()
        {
            if(prevReading>= 0  && currReading>=prevReading)
            {
                 return true;
            }
            else
            {
                return false;
            }
        }

    }


}
