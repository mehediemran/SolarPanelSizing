using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarPV
{
    public class GlobalVariables
    {
        public static double watt;
        public static double totKwatt;
        public static int housenumber;

        public static string ChosenPanelModel;
        public static double chosenpnelVolt;
        public static double chosenpnelPow;
        public static double chosenpnelCurrent;

        public static string ChosenBattModel;
        public static double chosenBattVolt;
        public static double chosenBattAH;
        public static double chosenBattCurrent;

        public static int noPanel;
        public static double days;
        public static double wattHourRequire;
        public static double battbankAH;
        public static int noofBatt;
        public static string ChosenLocation;
        public static string ChosenLocationIrrad;
    }
}
