﻿using WebAutopark.Core.Entities;
using WebAutopark.Core.Enums;

namespace WebAutopark.BusinessLogic.Models
{
    public class VehicleViewModel
    {
        private const double WeightCoefficient = 0.0013d;
        private const double ShiftForTax = 5d;
        private const double TaxCoefficient = 30d;

        #region Vehicle Property

        public int VehicleId { get; set; }
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }
        public string ModelName { get; set; }
        public string RegistrationNumber { get; set; }
        public int ManufactureYear { get; set; }
        public int Weight { get; set; }
        public int Mileage { get; set; }
        public ColorType Color { get; set; }
        public double TankCapacity { get; set; }
        public double EngineConsumption { get; set; }
        public double EnergyTankCapacity { get; set; }

        public virtual double GetCalcTaxPerMonth => Weight * WeightCoefficient + VehicleType.TaxCoefficient * TaxCoefficient + ShiftForTax;

        public virtual double KmPerFullTank => EnergyTankCapacity / EngineConsumption;

        #endregion
    }
}