﻿using System.ComponentModel.DataAnnotations;

namespace WebAppi.Entities
{
    public class MmkCoefDB
    {
        [Key]
        public int ID { get; set; }

        public required double FeCoef { get; set; }
        public required double SCoef { get; set; }
        public required double PCoef { get; set; }
        public required double CaOCoef { get; set; }
        public required double SiO2Coef { get; set; }
        public required double Al2O3Coef { get; set; }
        public required double MgOCoef { get; set; }
        public required double MnOCoef { get; set; }
        public required double TiO2Coef { get; set; }
        public required double ZnCoef { get; set; }
        public required double PMPPCoef { get; set; }
    }
}
