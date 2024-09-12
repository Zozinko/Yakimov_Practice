﻿using Console;
using Newtonsoft.Json;
using System;

namespace TestProgram;

public class Program
{

    public static void Main(string[] args)
    {
        var cocksick = new Cocksick
        {
            Weight = 4,
            PercentSera = 0.45,
            PercentZola = 17,
            PercentValotiles = 0.8
        };

        var shihtaComponents = new List<ShihtaComponent>()
        {
            new ShihtaComponent
            {
                Name = "к-т ММС-2",
                Weight = 0.0672,
                PMPP = 1.6,
                Wet = 9.8,
                Fe = 61,
                FeO = 30,
                CaO = 3.61,
                SiO2 = 6.6,
                MgO = 0.94,
                Al2O3 = 1.77,
                TiO2 = 0.21,
                S = 1.44,
                P = 0.017,
                Cr = 0.09,
                Zn = 0.014,
                MnO = 0.23
            },

            new ShihtaComponent
            {
                Name = "Лебед.к-т",
                Weight = 0.0423,
                PMPP = 0.28,
                Wet = 9.5,
                Fe = 68,
                FeO = 26.1,
                CaO = 0.28,
                SiO2 = 5.24,
                MgO = 0.3,
                Al2O3 = 0.21,
                TiO2 = 0,
                S = 0.05,
                P = 0.012,
                Cr = 0.005,
                Zn = 0.01,
                MnO = 0.04
            },

            new ShihtaComponent
            {
                Name = "ССГОК возвр.",
                Weight = 0,
                PMPP = 3,
                Wet = 9.8,
                Fe = 61,
                FeO = 0,
                CaO = 4.29,
                SiO2 = 4.22,
                MgO = 1.12,
                Al2O3 = 1.44,
                TiO2 = 0.27,
                S = 0.3,
                P = 0.01,
                Cr = 0.066,
                Zn = 0.066,
                MnO = 0.27
            },

            new ShihtaComponent
            {
                Name = "ССГОК к-т",
                Weight = 0.377,
                PMPP = 0.78,
                Wet = 9,
                Fe = 66,
                FeO = 29.7,
                CaO = 1.09,
                SiO2 = 3.6,
                MgO = 0.92,
                Al2O3 = 1.33,
                TiO2 = 0.29,
                S = 0.418,
                P = 0.014,
                Cr = 0.009,
                Zn = 0.014,
                MnO = 0.22
            },

            new ShihtaComponent
            {
                Name = "Стойл.к-т",
                Weight = 0.0613,
                PMPP = 1.2,
                Wet = 8.5,
                Fe = 66,
                FeO = 28,
                CaO = 0.35,
                SiO2 = 6.3,
                MgO = 0.32,
                Al2O3 = 0.3,
                TiO2 = 0,
                S = 0.031,
                P = 0.012,
                Cr = 0.007,
                Zn = 0.007,
                MnO = 0.04
            },

            new ShihtaComponent
            {
                Name = "Коршуновский к-т",
                Weight = 0.12,
                PMPP = 1.2,
                Wet = 9.6,
                Fe = 63,
                FeO = 23.3,
                CaO = 1.39,
                SiO2 = 3.1,
                MgO = 3.18,
                Al2O3 = 2.46,
                TiO2 = 0.28,
                S = 0.011,
                P = 0.078,
                Cr = 0.006,
                Zn = 0.012,
                MnO = 0.12
            },

            new ShihtaComponent
            {
                Name = "Мих.к-т",
                Weight = 0.0046,
                PMPP = 0.6,
                Wet = 9.2,
                Fe = 66,
                FeO = 24.6,
                CaO = 0.34,
                SiO2 = 7.32,
                MgO = 0.28,
                Al2O3 = 0.16,
                TiO2 = 0,
                S = 0.012,
                P = 0.012,
                Cr = 0.006,
                Zn = 0.018,
                MnO = 0.02
            },

            new ShihtaComponent
            {
                Name = "Ковдор. к-т",
                Weight = 0.0022,
                PMPP = 0.7,
                Wet = 7,
                Fe = 63,
                FeO = 23,
                CaO = 0.2,
                SiO2 = 0.99,
                MgO = 4.8,
                Al2O3 = 1.96,
                TiO2 = 1.11,
                S = 0.3,
                P = 0.12,
                Cr = 0.006,
                Zn = 0.006,
                MnO = 1.11
            },

            new ShihtaComponent
            {
                Name = "А/руда ММК",
                Weight = 0.0452,
                PMPP = 4.2,
                Wet = 1.5,
                Fe = 50,
                FeO = 4,
                CaO = 6.68,
                SiO2 = 13.63,
                MgO = 1.68,
                Al2O3 = 3.35,
                TiO2 = 0.25,
                S = 3.2,
                P = 0.046,
                Cr = 0.006,
                Zn = 0.018,
                MnO = 0.19
            },

            new ShihtaComponent
            {
                Name = "Богосл.а/р.",
                Weight = 0,
                PMPP = 3.4,
                Wet = 1.9,
                Fe = 54,
                FeO = 0,
                CaO = 6.01,
                SiO2 = 9.62,
                MgO = 1.32,
                Al2O3 = 2.83,
                TiO2 = 0.11,
                S = 2.39,
                P = 0.028,
                Cr = 0.006,
                Zn = 0.017,
                MnO = 0.21
            },

            new ShihtaComponent
            {
                Name = "Стойл.а/р.",
                Weight = 0.0433,
                PMPP = 11.2,
                Wet = 8.2,
                Fe = 52,
                FeO = 5,
                CaO = 1.1,
                SiO2 = 11.2,
                MgO = 0.8,
                Al2O3 = 2.5,
                TiO2 = 0.24,
                S = 0.12,
                P = 0.043,
                Cr = 0.008,
                Zn = 0.017,
                MnO = 0.07
            },

            new ShihtaComponent
            {
                Name = "Михайл.а/р.",
                Weight = 0.0762,
                PMPP = 5.5,
                Wet = 7.6,
                Fe = 55,
                FeO = 3.9,
                CaO = 1.38,
                SiO2 = 13.43,
                MgO = 0.32,
                Al2O3 = 1.55,
                TiO2 = 0.11,
                S = 0.431,
                P = 0.027,
                Cr = 0.017,
                Zn = 0.013,
                MnO = 0.04
            },

           new ShihtaComponent
            {
                Name = "\"Атансор\".а/р.",
                Weight = 0,
                PMPP = 8.1,
                Wet = 2.7,
                Fe = 56,
                FeO = 0,
                CaO = 0.36,
                SiO2 = 6.06,
                MgO = 0.39,
                Al2O3 = 3.2,
                TiO2 = 0,
                S = 0.07,
                P = 0.058,
                Cr = 0,
                Zn = 0,
                MnO = 0
            },

           new ShihtaComponent
            {
                Name = "Белор.а/р.",
                Weight = 0,
                PMPP = 9.5,
                Wet = 8.5,
                Fe = 43,
                FeO = 0,
                CaO = 0.18,
                SiO2 = 19.7,
                MgO = 0.6,
                Al2O3 = 5.1,
                TiO2 = 23,
                S = 0.66,
                P = 0.05,
                Cr = 0.005,
                Zn = 0.005,
                MnO = 0.23
            },

           new ShihtaComponent
            {
                Name = "Злат. Агл-т",
                Weight = 0,
                PMPP = 0,
                Wet = 0,
                Fe = 56,
                FeO = 0,
                CaO = 8.15,
                SiO2 = 5.51,
                MgO = 3.36,
                Al2O3 = 0.88,
                TiO2 = 0.13,
                S = 0.06,
                P = 0.038,
                Cr = 0.112,
                Zn = 0.112,
                MnO = 0.13
            },

           new ShihtaComponent
            {
                Name = "Отс.ССГПО",
                Weight = 0.0007,
                PMPP = 2,
                Wet = 6.7,
                Fe = 61,
                FeO = 1.5,
                CaO = 4.2,
                SiO2 = 4.15,
                MgO = 1,
                Al2O3 = 1.45,
                TiO2 = 0.29,
                S = 0.23,
                P = 0.01,
                Cr = 0.027,
                Zn = 0.027,
                MnO = 0.29
            },

           new ShihtaComponent
            {
                Name = "Шлам 4а/ф",
                Weight = 0.0155,
                PMPP = 2,
                Wet = 9.6,
                Fe = 57,
                FeO = 12.5,
                CaO = 8.8,
                SiO2 = 9.1,
                MgO = 1.8,
                Al2O3 = 1.4,
                TiO2 = 0.2,
                S = 0.16,
                P = 0.019,
                Cr = 0.017,
                Zn = 0.02,
                MnO = 0.02
            },

           new ShihtaComponent
            {
                Name = "Агломел.",
                Weight = 0.0151,
                PMPP = 0.2,
                Wet = 0,
                Fe = 58,
                FeO = 12.7,
                CaO = 7.96,
                SiO2 = 5.79,
                MgO = 1.71,
                Al2O3 = 1.54,
                TiO2 = 0.2,
                S = 0.07,
                P = 0.023,
                Cr = 0.012,
                Zn = 0.021,
                MnO = 0.21
            },

           new ShihtaComponent
            {
                Name = "Окалина.",
                Weight = 0.0181,
                PMPP = 2.96,
                Wet = 8.7,
                Fe = 71,
                FeO = 48,
                CaO = 3.7,
                SiO2 = 2.09,
                MgO = 0.56,
                Al2O3 = 0.42,
                TiO2 = 0.1,
                S = 0.05,
                P = 0.03,
                Cr = 0.059,
                Zn = 0.04,
                MnO = 0.45
            },

           new ShihtaComponent
            {
                Name = "Шлам ВФУ",
                Weight = 0.0127,
                PMPP = 10.2,
                Wet = 8.7,
                Fe = 54,
                FeO = 12.2,
                CaO = 4.96,
                SiO2 = 4.99,
                MgO = 1.43,
                Al2O3 = 1.61,
                TiO2 = 0.26,
                S = 0.308,
                P = 0.023,
                Cr = 0.009,
                Zn = 0.68,
                MnO = 0.2
            },

           new ShihtaComponent
            {
                Name = "К.шлак маг.",
                Weight = 0.0123,
                PMPP = 0,
                Wet = 5.6,
                Fe = 40,
                FeO = 10.4,
                CaO = 19.67,
                SiO2 = 13.94,
                MgO = 7.88,
                Al2O3 = 3.41,
                TiO2 = 0.75,
                S = 0.084,
                P = 0.16,
                Cr = 0.27,
                Zn = 0,
                MnO = 2.1
            },

           new ShihtaComponent
            {
                Name = "Бак.сид.",
                Weight = 0.033,
                PMPP = 31.2,
                Wet = 4.8,
                Fe = 35,
                FeO = 36.4,
                CaO = 3.45,
                SiO2 = 6.07,
                MgO = 8.03,
                Al2O3 = 2.08,
                TiO2 = 0.1,
                S = 0.082,
                P = 0.22,
                Cr = 0.005,
                Zn = 0.013,
                MnO = 1.66
            },

           new ShihtaComponent
            {
                Name = "Известь",
                Weight = 0.0247,
                PMPP = 12,
                Wet = 0,
                Fe = 0,
                FeO = 0,
                CaO = 85,
                SiO2 = 0.1,
                MgO = 5,
                Al2O3 = 0.3,
                TiO2 = 0,
                S = 0,
                P = 0,
                Cr = 0,
                Zn = 0,
                MnO = 0
            },
        };

        var shihta = new Shihta(shihtaComponents);

        var zolaOfCocksick = new ZolaOfCocksick
        {
            Fe = 5.4,
            CaO = 7.8,
            SiO2 = 48.1,
            Al2O3 = 24.6,
            MgO = 2,
            P = 0.04
        };

        var fluxAddition = new FluxAdditions
        {
            DolomyteAl2O3 = 0.04,
            DolomyteCaO = 34.8,
            DolomyteMgO = 18,
            DolomyteSiO2 = 0.13,
            IzvestnyakAl2O3 = 0.05,
            IzvestnyakCaO = 51.8,
            IzvestnyakMgO = 3.2,
            IzvestnyakSiO2 = 0.17
        };

        var startEnter = new StartEnter
        {
            osnovnost = 1.4,
            DolomyteInAgl = 0,
            FeOinAgl = 12
        };

        var mmkCoef = new MmkCoef
        {
            Al2O3Coef = 1.01,
            CaOCoef = 1.01,
            FeCoef = 0.995,
            MgOCoef = 0.92,
            MnOCoef = 1,
            PCoef = 1.1,
            PMPPCoef = 1,
            SCoef = 0.06,
            SiO2Coef = 1.02,
            TiO2Coef = 1,
            ZnCoef = 0.7
        };

        var calcLES = new CalcLES(shihta, fluxAddition, cocksick, startEnter, zolaOfCocksick);

        var end = new List<END>()
        {
            new END
            {
                ReportComponentOfShihta = calcLES.ConsimtionJRM,
                ReportPercentOfFe = shihta.TotalFeMass,
                ReportPercentOfS = shihta.TotalSMass,
                ReportPercentOfP = shihta.TotalPMass,
                ReportPercentOfFeO = shihta.TotalFeOMass,
                ReportPercentOfCaO = shihta.TotalCaOMass,
                ReportPercentOfSiO2 = shihta.TotalSiO2Mass,
                ReportPercentOfAl2O3 = shihta.TotalAl2O3Mass,
                ReportPercentOfMgO = shihta.TotalMgOMass,
                ReportPercentOfMnO = shihta.TotalMnOMass,
                ReportPercentOfTiO2 = shihta.TotalTiO2Mass,
                ReportPercentOfZn = shihta.TotalZnMass,
                ReportPercentOfPMPP = shihta.TotalPercentOfPMPP
            },

            new END
            {
                ReportComponentOfShihta = calcLES.ConsimitionIzvestyak,
                ReportPercentOfFe = 0,
                ReportPercentOfS = 0,
                ReportPercentOfP = 0,
                ReportPercentOfFeO = 0,
                ReportPercentOfCaO = fluxAddition.IzvestnyakCaO,
                ReportPercentOfSiO2 = fluxAddition.IzvestnyakSiO2,
                ReportPercentOfAl2O3 = fluxAddition.IzvestnyakAl2O3,
                ReportPercentOfMgO = fluxAddition.IzvestnyakMgO,
                ReportPercentOfMnO = 0,
                ReportPercentOfTiO2 = 0,
                ReportPercentOfZn = 0,
                ReportPercentOfPMPP = fluxAddition.IzvestnyakPMPP
            },

            new END
            {
                ReportComponentOfShihta = startEnter.DolomyteInAgl,
                ReportPercentOfFe = 0,
                ReportPercentOfS = 0,
                ReportPercentOfP = 0,
                ReportPercentOfFeO = 0,
                ReportPercentOfCaO = fluxAddition.DolomyteCaO,
                ReportPercentOfSiO2 = fluxAddition.DolomyteSiO2,
                ReportPercentOfAl2O3 = fluxAddition.DolomyteAl2O3,
                ReportPercentOfMgO = fluxAddition.DolomyteMgO,
                ReportPercentOfMnO = 0,
                ReportPercentOfTiO2 = 0,
                ReportPercentOfZn = 0,
                ReportPercentOfPMPP = fluxAddition.DolomytePMPP
            },

            new END
            {
                ReportComponentOfShihta = cocksick.Weight,
                ReportPercentOfFe = 0,
                ReportPercentOfS = cocksick.PercentSera,
                ReportPercentOfP = 0,
                ReportPercentOfFeO = 0,
                ReportPercentOfCaO = 0,
                ReportPercentOfSiO2 = 0,
                ReportPercentOfAl2O3 = 0,
                ReportPercentOfMgO = 0,
                ReportPercentOfMnO = 0,
                ReportPercentOfTiO2 = 0,
                ReportPercentOfZn = 0,
                ReportPercentOfPMPP = 0
            },

            new END
            {
                ReportComponentOfShihta = cocksick.Weight * cocksick.PercentZola / 100,
                ReportPercentOfFe = zolaOfCocksick.Fe,
                ReportPercentOfS = 0,
                ReportPercentOfP = zolaOfCocksick.P,
                ReportPercentOfFeO = 0,
                ReportPercentOfCaO = zolaOfCocksick.CaO,
                ReportPercentOfSiO2 = zolaOfCocksick.SiO2,
                ReportPercentOfAl2O3 = zolaOfCocksick.Al2O3,
                ReportPercentOfMgO = zolaOfCocksick.MgO,
                ReportPercentOfMnO = 0,
                ReportPercentOfTiO2 = 0,
                ReportPercentOfZn = 0,
                ReportPercentOfPMPP = 0

            }
        };

        var sostavAglom = new SostavAglom(startEnter, mmkCoef, end);
    }
}
