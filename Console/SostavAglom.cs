using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class SostavAglom(StartEnter startEnter, MmkCoef mmkCoef, List<END> Components)
    {
        public MmkShihta mmkShihta => new MmkShihta(this,  mmkCoef);
        public double TotalReportFe => Components.Sum(x => x.ReportFe);
        public double TotalReportS => Components.Sum(x => x.ReportS);
        public double TotalReportP => Components.Sum(x => x.ReportP);
        public double TotalReportFeO => Components.Sum(x => x.ReportFeO);
        public double TotalReportCaO => Components.Sum(x => x.ReportCaO);
        public double TotalReportSiO2 => Components.Sum(x => x.ReportSiO2);
        public double TotalReportAl2O3 => Components.Sum(x => x.ReportAl2O3);
        public double TotalReportMgO => Components.Sum(x => x.ReportMgO);
        public double TotalReportMnO => Components.Sum(x => x.ReportMnO);
        public double TotalReportTiO2 => Components.Sum(x => x.ReportTiO2);
        public double TotalReportZn => Components.Sum(x => x.ReportZn);
        public double TotalReportPMPP => Components.Sum(x => x.ReportPMPP);
        public double TotalReportShihta => Components.Sum(x => x.ReportComponentOfShihta);


        public double GoesToAglomFe => TotalReportFe;
        public double GoesToAglomS => TotalReportS;
        public double GoesToAglomP => TotalReportP;
        public double GoesToAglomFeO => startEnter.FeOinAgl;
        public double GoesToAglomFe2O3 => (GoesToAglomFe - 56d / 72d * startEnter.FeOinAgl) * 160d / 112d;
        public double GoesToAglomCaO => TotalReportCaO;
        public double GoesToAglomSiO2 => TotalReportSiO2;
        public double GoesToAglomAl2O3 => TotalReportAl2O3;
        public double GoesToAglomMgO => TotalReportMgO;
        public double GoesToAglomMnO => TotalReportMnO;
        public double GoesToAglomTiO2 => TotalReportTiO2;
        public double GoesToAglomZn => TotalReportZn;
        public double GoesToAglomPMPP => TotalReportPMPP;
        public double TotalGoesToAglom => GoesToAglomS + GoesToAglomP
            + GoesToAglomFeO
            + GoesToAglomFe2O3
            + GoesToAglomCaO
            + GoesToAglomSiO2
            + GoesToAglomAl2O3
            + GoesToAglomMgO
            + GoesToAglomMnO
            + GoesToAglomTiO2
            + GoesToAglomZn;

        public double CaOSiO2 => GoesToAglomCaO / GoesToAglomSiO2;
    } 
}