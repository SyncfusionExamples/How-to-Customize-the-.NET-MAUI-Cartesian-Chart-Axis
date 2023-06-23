using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;

namespace MAUI_ChartAxis
{
    public class ChartDataModel
    {
        public DateTime Date { get; set; }

        public double Value { get; set; }

       
        public ChartDataModel() { }

       
        public ChartDataModel(DateTime dateTime, double value)
        {
            Date = dateTime;
            Value = value;
        }
    }
}
